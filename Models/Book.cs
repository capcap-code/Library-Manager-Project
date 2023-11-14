using System;
using System.Collections.Generic;
using System.Data;
using DoAn.ultilities;
using MySql.Data.MySqlClient;

namespace Project.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } 
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Fines { get; set; }

        private MySQLConnect DbCon;

        public Book()
        {
            DbCon = new MySQLConnect();
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            if (DbCon.OpenConnection())
            {
                string query = "SELECT * FROM book";
                MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book();
                    book.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    book.Title = reader["title"].ToString();
                    book.Description = reader["description"].ToString();
                    book.Image = reader["image"].ToString(); 
                    book.Price = reader.GetInt32(reader.GetOrdinal("price"));
                    book.Quantity = reader.GetInt32(reader.GetOrdinal("quantity"));
                    book.Fines = reader.GetInt32(reader.GetOrdinal("fines"));
                    books.Add(book);
                }

                reader.Close();
                DbCon.CloseConnection();
            }

            return books;
        }
    

        public Book GetBookById(int id)
        {
            if (DbCon.OpenConnection())
            {
                string query = "SELECT * FROM book where id = @id";
                MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Book book = new Book();
                    book.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    book.Title = reader["title"].ToString();
                    book.Description = reader["description"].ToString();
                    book.Image = reader["image"].ToString();
                    book.Price = reader.GetInt32(reader.GetOrdinal("price"));
                    book.Quantity = reader.GetInt32(reader.GetOrdinal("quantity"));
                    book.Fines = reader.GetInt32(reader.GetOrdinal("fines"));
                    reader.Close();
                    return book;
                }
                reader.Close();
                DbCon.CloseConnection();
                return null;
            }
            else
            {
                return null; 
            }
        }


        public bool CreateBook(string title, string description, int price, int fines, string Image, int quantity)
        {
            if (DbCon.OpenConnection())
            {
                try
                {
                    string query = "INSERT INTO book (title, description, price, fines, image, quantity) VALUES (@title, @description, @price, @fines, @image, @quantity)";
                    MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@fines", fines);
                    cmd.Parameters.AddWithValue("@image", Image); 
                    cmd.Parameters.AddWithValue("@quantity", quantity);

                    int affectedRows = cmd.ExecuteNonQuery();
                    return affectedRows > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error creating book: " + ex.Message);
                    return false;
                }
                finally
                {
                    DbCon.CloseConnection();
                }
            }
            else
            {
                return false;
            }
        }


        public bool EditBook(int id, string title, string description, int price, int fines, string Image, int quantity)
        {
            if (DbCon.OpenConnection())
            {
                try
                {
                    string query = "UPDATE book SET title = @title, description = @description, price = @price, fines = @fines, image = @image, quantity = @quantity WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, DbCon.GetConnection());
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@fines", fines);
                    cmd.Parameters.AddWithValue("@image", Image); 
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@id", id);

                    int affectedRows = cmd.ExecuteNonQuery();
                    return affectedRows > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error editing book: " + ex.Message);
                    return false;
                }
                finally
                {
                    DbCon.CloseConnection();
                }
            }
            else
            {
                return false;
            }
        }


        public bool DeleteBook(int id, string username)
        {
            if (DbCon.OpenConnection())
            {
                try
                {
        
                    MySqlCommand cmd = new MySqlCommand("DeleteBook", DbCon.GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;

                  
                    cmd.Parameters.AddWithValue("_BookId", id);


                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Delete Sucess");
                    return true;
                    
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine("Error deleting book: " + ex.Message);
                    return false; 
                }
                finally
                {
                    DbCon.CloseConnection();
                }
            }

            return false;
        }
    }
}
