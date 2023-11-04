using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DoAn.ultilities;

namespace DoAn.view
{
    public partial class adminForm : Form
    {
        int currentPage = 1;
        int itemsPerPage = 4;
        int totalClients = 0;
        int totalPages = 0;

        public adminForm()
        {
            InitializeComponent();
            Load += new EventHandler(adminForm_Load);
            DbCon = new MySQLConnect();
        }

        private MySQLConnect DbCon;

        public int GetTotalClientsCount()
        {
            int totalClients = 0;
            try
            {
                using (MySqlConnection connection = DbCon.GetConnection())
                {
                    if (DbCon.OpenConnection())
                    {
                        string query = "SELECT COUNT(*) FROM Clients";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        totalClients = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                DbCon.CloseConnection();
            }

            return totalClients;
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            totalClients = GetTotalClientsCount();
            totalPages = (int)Math.Ceiling((double)totalClients / itemsPerPage);
            LoadPage(currentPage);
        }

        private List<clientData1> GetClientsForPage(int page, int itemsPerPage)
        {
            List<clientData1> clients = new List<clientData1>();
            MySqlConnection connection = DbCon.GetConnection();

            if (connection != null)
            {
                try
                {
                    int startRow = (page - 1) * itemsPerPage;
                    connection.Open();
                    string query = $"SELECT * FROM Clients ORDER BY ClientID LIMIT {startRow}, {itemsPerPage}";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientData1 client = new clientData1
                            {
                                Name = reader["Name"].ToString(),
                            };
                            clients.Add(client);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error retrieving client data: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return clients;
        }

        private void LoadPage(int page)
        {
            List<clientData1> clients = GetClientsForPage(page, itemsPerPage);
            clientLayout.Controls.Clear();

            foreach (var client in clients)
            {
                clientData1 clientControl = new clientData1();
                clientControl.CustomerName = client.Name;
                clientLayout.Controls.Add(clientControl);
            }

            pageCountLabel.Text = $"{currentPage} of {totalPages}";
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadPage(currentPage);
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage(currentPage);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                clientData1 customerPanel = new clientData1();
                customerPanel.CustomerName = "Customer " + i;
                customerPanel.CustomerPhone = "Phone " + i;
                customerPanel.RentedBooksCount = "So sach dang muon " + i;
                clientLayout.Controls.Add(customerPanel);
            }
        }
    }
}
