using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DoAn.ultilities;
using System.Drawing;
using Project.Models;
using MySqlX.XDevAPI;

namespace DoAn.view
{
    public partial class adminForm : Form
    {

        public adminForm()
        {
            InitializeComponent();
            Load += new EventHandler(adminForm_Load);
            this.BackColor = Color.FromArgb(252, 252, 252);
            editBookBtn.MouseEnter += editBookBtn_MouseEnter;
            editBookBtn.MouseLeave += editBookBtn_MouseLeave;
            editBookBtn.Size = new Size(100, 50);


            editCusBtn.MouseEnter += editCusBtn_MouseEnter;
            editCusBtn.MouseLeave += editCusBtn_MouseLeave;
            editCusBtn.Size = new Size(100, 50); 
            
        }

        private void editBookBtn_MouseEnter(object sender, EventArgs e)
        {
            editBookBtn.BackColor = Color.FromArgb(68, 62, 60);
            editBookBtn.ForeColor = Color.FromArgb(234, 234, 234);
        }

        private void editBookBtn_MouseLeave(object sender, EventArgs e)
        {
            editBookBtn.BackColor = Color.FromArgb(234, 234, 234);
            editBookBtn.ForeColor = Color.FromArgb (68, 62, 60);
        }
        private void editCusBtn_MouseEnter(object sender, EventArgs e)
        {
            editCusBtn.BackColor = Color.FromArgb(68, 62, 60);
            editCusBtn.ForeColor = Color.FromArgb(234, 234, 234);
        }

        private void editCusBtn_MouseLeave(object sender, EventArgs e)
        {
            editCusBtn.BackColor = Color.FromArgb(234, 234, 234);
            editCusBtn.ForeColor = Color.FromArgb(68, 62, 60);
        }

        private MySQLConnect DbCon;

        private void adminForm_Load(object sender, EventArgs e)
        {
            LoadTopClients(); 
        }

        private void LoadTopClients()
        {
            DbCon = new MySQLConnect();
            List<clientData1> clients = GetTopClients(4); 

            clientLayout.Controls.Clear();
            foreach (var client in clients)
            {
                clientLayout.Controls.Add(client);
            }
            DbCon.CloseConnection();
        }

        private List<clientData1> GetTopClients(int count)
        {
            List<clientData1> clients = new List<clientData1>();

            using (MySqlConnection connection = DbCon.GetConnection())
            {
                if (connection != null && DbCon.OpenConnection())
                {
                    string query = $"SELECT * FROM user ORDER BY id LIMIT {count}";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientData1 clientControl = new clientData1();
                            clientControl.CustomerName = reader["username"].ToString();
                            clientControl.CustomerPhone = reader["phoneNumber"].ToString();
                            clientControl.CustomerAdress = reader["address"].ToString();
                            clients.Add(clientControl);
                        }
                    }
                }
            }

            return clients;
        }

        private void editBookBtn_Click(object sender, EventArgs e)
        {
            editBookForm editbookForm = new editBookForm();
            editbookForm.Show();
        }

        public void searchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = searchInput.Text.Trim();

            User userInstance = new User();

            List<User> searchResults = userInstance.GetCustomers(searchQuery);

            DisplaySearchResults(searchResults);
        }


        private void DisplaySearchResults(List<User> searchResults)
        {
            clientLayout.Controls.Clear();

            foreach (User user in searchResults)
            {
                clientData1 clientControl = new clientData1();
                clientControl.CustomerName = user.Username;
                clientControl.CustomerPhone = user.Phone;
                clientControl.CustomerAdress = user.Address;
                clientLayout.Controls.Add(clientControl);
            }
        }
    }
}
