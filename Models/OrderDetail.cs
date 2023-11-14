using DoAn.ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DoAn.Models
{
    internal class OrderDetails
    {
        public int id;
        public int bookId;
        public int quantity;
        public int orderId;
        private MySQLConnect DbCon;
        public OrderDetails()
        {
            DbCon = new MySQLConnect();
        }
        public OrderDetails(int bookId, int quantity)
        {
            DbCon = new MySQLConnect();
            this.bookId = bookId;
            this.quantity = quantity;
        }
        public Boolean CreateOrderDetail(int orderId, int bookId, int quantity)
        {
            if (DbCon.OpenConnection())
            {
                string query = "Call CreateOrderDetail(@orderId, @bookId, @quantity)";
                MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                cmd.Parameters.AddWithValue("@orderId", orderId);
                cmd.Parameters.AddWithValue("@bookId", bookId);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                object result = cmd.ExecuteScalar();
                bool isCreated = Convert.ToBoolean(result);
                return isCreated;
            }
            return false;
        }
    }
}
