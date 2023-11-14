using DoAn.ultilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public DateTime date_return { get; set; }
        private MySQLConnect DbCon;

        public Order()
        {
            DbCon = new MySQLConnect();
        }
        //public bool CreareOrder(string userId, DateTime date_return, List<OrderDetail> details)
        //{
        //    using (MySqlConnection connection = DbCon.GetConnection())
        //    {
        //        if (DbCon.OpenConnection())
        //        {
        //            string query = "Insert";
        //            MySqlCommand command = new MySqlCommand(query, connection);
        //            object result = command.ExecuteScalar();
        //            bool isCreated = Convert.ToBoolean(result);
        //            DbCon.CloseConnection();
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }                  
        //}

        public Boolean CreateOrder(int userId, DateTime dateReturn, List<OrderDetails> orderDetails)
        {
            if (DbCon.OpenConnection())
            {
                string query = "Insert Into Orders (userId, dateReturn) values (@userId, @dateReturn)";
                MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@dateReturn", dateReturn);
                cmd.ExecuteNonQuery();
                long newOrderId = cmd.LastInsertedId;
                Boolean result = false;
                if (newOrderId > 0)
                {
                    foreach (OrderDetails detail in orderDetails)
                    {
                        OrderDetails newOrder = new OrderDetails();
                        result = newOrder.CreateOrderDetail((int)newOrderId, detail.bookId, detail.quantity);
                        if (result != true)
                        {
                            MessageBox.Show("Tạo ordertail thất bại");
                            break;
                        }
                    }
                }
                DbCon.CloseConnection();
                return result;
            }
            return false;
        }
    }
}

