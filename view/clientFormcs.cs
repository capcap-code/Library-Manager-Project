using Project.Models;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using DoAn.ultilities;

namespace DoAn.view
{
    public partial class clientForm : Form
    {
        private List<Book> books;

        public clientForm()
        {
            InitializeComponent();
        }
        private MySQLConnect DbCon;
        private void clientForm_Load(object sender, EventArgs e)
        {
            LoadBooksFromDatabase();
            DisplayBooks();
        }

        private void LoadBooksFromDatabase()
        {
            // Implement code to load books from the database into the 'books' list
            Book bookModel = new Book();
            books = bookModel.GetAllBooks();
        }

        private void DisplayBooks()
        {
            DbCon = new MySQLConnect();
            List<bookData> book = new List<bookData>();
            foreach (Book book in books)
            {
                bookData bookControl = new bookData();
                bookControl.SetBookData(book.Title, book.Description, book.Price, book.Quantity, book.Image);
                bookPanel.Controls.Add(bookControl);
            }
        }
    }
}
