using MySqlX.XDevAPI;
using System;
using System.Drawing;
using System.Windows.Forms;
using DoAn.ultilities;
using MySql.Data.MySqlClient;

namespace DoAn.view
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(234, 234, 234);
            DbCon = new MySQLConnect();
        }
        private MySQLConnect DbCon;
        private void registBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registForm = new RegisterForm();
            this.Hide();
            registForm.Show();
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Authenticate 
            int userRole = AuthenticateUserAndGetRole(username, password);

            if (userRole == -1)
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
            else if (userRole == 2 )
            {
                // Admin user
                adminForm adminForm = new adminForm();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                // Client user
                clientForm clientForm = new clientForm();
                clientForm.Show();
                this.Hide();
            }
        }

        private int AuthenticateUserAndGetRole(string username, string password)
        {
            int userRole = -1;
            using (MySqlConnection connection = DbCon.GetConnection())
            {
                connection.Open();

                string query = "SELECT Role FROM user WHERE Username = @Username AND Password = @Password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userRole = Convert.ToInt32(reader["Role"]);
                    }
                }
            }

            return userRole;
        }
    }
}
