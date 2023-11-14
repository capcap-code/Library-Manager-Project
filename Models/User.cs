using DoAn.ultilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Project.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }

        public string Phone { get; set; }
        public int Role { get; set; }
        private MySQLConnect DbCon;

        public User()
        {
            DbCon = new MySQLConnect();
        }
        public User Login(string username, string password)
        {
            if (DbCon.OpenConnection())
            {
                string query = "Select * from user where username = @username and password = @password)";
                MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    User user = new User();
                    user.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    user.Username = reader["username"].ToString();
                    user.Role = reader.GetInt32(reader.GetOrdinal("role"));
                    user.Address = reader["address"].ToString();
                    return user;
                }
                DbCon.CloseConnection();
                return null;
            }
            else
            {
                return null;
            }
        }

     
        public  List<User> GetCustomers(string searchQuery)
        {
            List<User> users = new List<User>();
            if (DbCon.OpenConnection())
            {
                string query = $"Select * from user where role = '1' AND (username LIKE '%{searchQuery}%' OR phoneNumber LIKE '%{searchQuery}%')";
                MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    user.Username = reader["username"].ToString();
                    user.Role = reader.GetInt32(reader.GetOrdinal("role"));
                    user.Address = reader["phoneNumber"].ToString();
                    users.Add(user);
                }
                DbCon.CloseConnection();
            }
            return users;
        }
        public List<User> GetAdmins()
        {
            List<User> users = new List<User>();
            if (DbCon.OpenConnection())
            {
                string query = "Select * from user where role = '2'";
                MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    user.Username = reader["username"].ToString();
                    user.Role = reader.GetInt32(reader.GetOrdinal("role"));
                    user.Address = reader["address"].ToString();
                    users.Add(user);
                }
                DbCon.CloseConnection();
            }
            return users;
        }


        public bool Register(string username, string password)
        {
            if (DbCon.OpenConnection())
            {
                string query = "Call CreateUser(@username, @password)";
                MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                object result = cmd.ExecuteScalar();
                bool isCreated = Convert.ToBoolean(result);
                DbCon.CloseConnection();
                return isCreated;
            }
            else
            {
                return false;
            }
        }
    }
}
