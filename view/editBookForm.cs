using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.view
{
    public partial class editBookForm : Form
    {
        private List<Book> books;

        public editBookForm()
        {
            InitializeComponent();
            books = new List<Book>();
            Load += editBookForm_Load;
            refreshBtn.Click += RefreshBtn_Click;
            deleteBookBtn.Click += DeleteBookBtn_Click;

            booksDataGridView.CellEndEdit += BooksDataGridView_CellEndEdit;
            booksDataGridView.CellClick += BooksDataGridView_CellClick;
        }

        private void editBookForm_Load(object sender, EventArgs e)
        {
            LoadAllBooks();
            DisplayBooksInGridView();
        }

        private void LoadAllBooks()
        {
            Book bookModel = new Book();
            books = bookModel.GetAllBooks();
            
        }

        private void DisplayBooksInGridView()
        {
            booksDataGridView.DataSource = books;
        }


        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadAllBooks();
            DisplayBooksInGridView();
        }


        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            if (booksDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = booksDataGridView.SelectedRows[0];

                if (selectedRow.DataBoundItem != null)
                {
                    Book selectedBook = (Book)selectedRow.DataBoundItem;

                    DialogResult result = MessageBox.Show($"Are you sure you want to delete the book '{selectedBook.Title}'?",
                                                          "Confirm Deletion",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        bool isDeleted = selectedBook.DeleteBook(selectedBook.Id, "admin");

                        if (isDeleted)
                        {
                            MessageBox.Show("Delete success", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllBooks();
                            DisplayBooksInGridView();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the book.", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid data bound item.", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void BooksDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < booksDataGridView.Rows.Count)
            {
                DataGridViewRow row = booksDataGridView.Rows[e.RowIndex];

                if (row.DataBoundItem != null)
                {
                    Book editedBook = (Book)row.DataBoundItem;

                    bool isUpdated = editedBook.EditBook(
                        editedBook.Id,
                        editedBook.Title,
                        editedBook.Description,
                        editedBook.Price,
                        editedBook.Fines,
                        editedBook.Image,
                        editedBook.Quantity
                    );

                    if (isUpdated)
                    {
                        MessageBox.Show("Book updated successfully.", "Update Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the book.", "Update Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid data bound item.", "Update Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void BooksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < books.Count)
            {
                Book selectedBook = books[e.RowIndex];

                if (!string.IsNullOrEmpty(selectedBook.Image))
                {
                    try
                    {
                        bookImg.Image = Image.FromFile(selectedBook.Image);
                        bookImg.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Image path not available", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void ClearInputFields()
        {
            bookNameTxt.Text = "";
            bookDescTxt.Text = "";
            bookPriceTxt.Text = "";
            BookFinesTxt.Text = "";
            bookQuantTxt.Text = "";
        }

        private void addBookBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string title = bookNameTxt.Text;
                string description = bookDescTxt.Text;
                int price = int.Parse(bookPriceTxt.Text);
                int fines = int.Parse(BookFinesTxt.Text);

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp) | *.jpg; *.jpeg; *.png; *.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    int quantity = int.Parse(bookQuantTxt.Text);

                    Book bookModel = new Book();

                    bool isBookCreated = bookModel.CreateBook(title, description, price, fines, imagePath, quantity);


                    if (isBookCreated)
                    {
                        MessageBox.Show("Book added successfully.", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllBooks();
                        DisplayBooksInGridView();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the book.", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
