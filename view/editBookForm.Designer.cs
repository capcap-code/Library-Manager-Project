namespace DoAn.view
{
    partial class editBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editBookForm));
            this.refreshBtn = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.deleteBookBtn = new System.Windows.Forms.Button();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.bookNameTxt = new System.Windows.Forms.TextBox();
            this.bookPriceTxt = new System.Windows.Forms.TextBox();
            this.bookDescTxt = new System.Windows.Forms.TextBox();
            this.bookQuantTxt = new System.Windows.Forms.TextBox();
            this.BookFinesTxt = new System.Windows.Forms.TextBox();
            this.bookImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.BackgroundImage")));
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Location = new System.Drawing.Point(1040, 78);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(120, 60);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.UseVisualStyleBackColor = false;
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBookBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBookBtn.BackgroundImage")));
            this.addBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBookBtn.FlatAppearance.BorderSize = 0;
            this.addBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookBtn.Location = new System.Drawing.Point(1040, 176);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(120, 60);
            this.addBookBtn.TabIndex = 1;
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click_1);
            // 
            // deleteBookBtn
            // 
            this.deleteBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBookBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBookBtn.BackgroundImage")));
            this.deleteBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBookBtn.FlatAppearance.BorderSize = 0;
            this.deleteBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBookBtn.Location = new System.Drawing.Point(1040, 267);
            this.deleteBookBtn.Name = "deleteBookBtn";
            this.deleteBookBtn.Size = new System.Drawing.Size(120, 60);
            this.deleteBookBtn.TabIndex = 3;
            this.deleteBookBtn.UseVisualStyleBackColor = false;
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToOrderColumns = true;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Location = new System.Drawing.Point(12, 54);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.RowHeadersWidth = 51;
            this.booksDataGridView.RowTemplate.Height = 24;
            this.booksDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.booksDataGridView.Size = new System.Drawing.Size(1000, 299);
            this.booksDataGridView.TabIndex = 4;
            // 
            // bookNameTxt
            // 
            this.bookNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameTxt.Location = new System.Drawing.Point(39, 23);
            this.bookNameTxt.Name = "bookNameTxt";
            this.bookNameTxt.Size = new System.Drawing.Size(131, 30);
            this.bookNameTxt.TabIndex = 5;
            this.bookNameTxt.Text = "Name";
            // 
            // bookPriceTxt
            // 
            this.bookPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPriceTxt.Location = new System.Drawing.Point(372, 23);
            this.bookPriceTxt.Name = "bookPriceTxt";
            this.bookPriceTxt.Size = new System.Drawing.Size(131, 30);
            this.bookPriceTxt.TabIndex = 6;
            this.bookPriceTxt.Text = "Price ";
            // 
            // bookDescTxt
            // 
            this.bookDescTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDescTxt.Location = new System.Drawing.Point(203, 23);
            this.bookDescTxt.Name = "bookDescTxt";
            this.bookDescTxt.Size = new System.Drawing.Size(131, 30);
            this.bookDescTxt.TabIndex = 7;
            this.bookDescTxt.Text = "Description ";
            // 
            // bookQuantTxt
            // 
            this.bookQuantTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookQuantTxt.Location = new System.Drawing.Point(543, 23);
            this.bookQuantTxt.Name = "bookQuantTxt";
            this.bookQuantTxt.Size = new System.Drawing.Size(131, 30);
            this.bookQuantTxt.TabIndex = 8;
            this.bookQuantTxt.Text = "Quantities";
            // 
            // BookFinesTxt
            // 
            this.BookFinesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookFinesTxt.Location = new System.Drawing.Point(713, 23);
            this.BookFinesTxt.Name = "BookFinesTxt";
            this.BookFinesTxt.Size = new System.Drawing.Size(131, 30);
            this.BookFinesTxt.TabIndex = 11;
            this.BookFinesTxt.Text = "Fines";
            // 
            // bookImg
            // 
            this.bookImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookImg.Location = new System.Drawing.Point(12, 368);
            this.bookImg.Name = "bookImg";
            this.bookImg.Size = new System.Drawing.Size(212, 218);
            this.bookImg.TabIndex = 12;
            this.bookImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BookFinesTxt);
            this.panel1.Controls.Add(this.bookNameTxt);
            this.panel1.Controls.Add(this.bookDescTxt);
            this.panel1.Controls.Add(this.bookQuantTxt);
            this.panel1.Controls.Add(this.bookPriceTxt);
            this.panel1.Location = new System.Drawing.Point(12, 646);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 73);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add New Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "View Book";
            // 
            // editBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookImg);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.deleteBookBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.refreshBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Book";
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button deleteBookBtn;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.TextBox bookNameTxt;
        private System.Windows.Forms.TextBox bookPriceTxt;
        private System.Windows.Forms.TextBox bookDescTxt;
        private System.Windows.Forms.TextBox bookQuantTxt;
        private System.Windows.Forms.TextBox BookFinesTxt;
        private System.Windows.Forms.PictureBox bookImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}