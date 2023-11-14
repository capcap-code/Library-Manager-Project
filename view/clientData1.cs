using DoAn.ultilities;
using Project.Models;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DoAn.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections.Generic;
using System;

namespace DoAn.view
{
    public partial class clientData1 : UserControl
    {
        public clientData1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(234, 234, 234);
        }
        [Category("clientData")]
        public string CustomerName
        {
            get { return clientName.Text; }
            set { clientName.Text = value; }
        }

        [Category("clientData")]
        public string CustomerAdress
        {
            get { return clientAdress.Text; }
            set { clientAdress.Text = value; }
        }

        [Category("clientData")]
        public string CustomerPhone
        {
            get { return clientPhone.Text; }
            set { clientPhone.Text = value; }
        }

        [Category("clientData")]
        public string RentedBooksCount
        {
            get { return clientBook.Text; }
            set { clientBook.Text = value; }
        }
        private MySQLConnect DbCon;
        private void CreateOrder_Click(object sender, System.EventArgs e)
        {
            MySqlConnection connection = DbCon.GetConnection();
            connection.Open();
            Order order = new Order();


        }
    }
}
