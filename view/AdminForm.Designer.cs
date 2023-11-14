namespace DoAn.view
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.editCusBtn = new System.Windows.Forms.Button();
            this.editBookBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.clientLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.clientData11 = new DoAn.view.clientData1();
            this.loadMorebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchInput);
            this.panel1.Controls.Add(this.editCusBtn);
            this.panel1.Controls.Add(this.editBookBtn);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 92);
            this.panel1.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBtn.BackgroundImage")));
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(485, 26);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(152, 50);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchInput
            // 
            this.searchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Location = new System.Drawing.Point(307, 30);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(172, 36);
            this.searchInput.TabIndex = 4;
            // 
            // editCusBtn
            // 
            this.editCusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCusBtn.Location = new System.Drawing.Point(840, 26);
            this.editCusBtn.Name = "editCusBtn";
            this.editCusBtn.Size = new System.Drawing.Size(100, 50);
            this.editCusBtn.TabIndex = 3;
            this.editCusBtn.Text = "Sửa Khách";
            this.editCusBtn.UseVisualStyleBackColor = true;
            // 
            // editBookBtn
            // 
            this.editBookBtn.FlatAppearance.BorderSize = 0;
            this.editBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookBtn.Location = new System.Drawing.Point(701, 26);
            this.editBookBtn.Name = "editBookBtn";
            this.editBookBtn.Size = new System.Drawing.Size(100, 50);
            this.editBookBtn.TabIndex = 2;
            this.editBookBtn.Text = "Sửa Sách";
            this.editBookBtn.UseVisualStyleBackColor = true;
            this.editBookBtn.Click += new System.EventHandler(this.editBookBtn_Click);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(23, 5);
            this.Title.Margin = new System.Windows.Forms.Padding(3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(230, 84);
            this.Title.TabIndex = 1;
            this.Title.Text = "Library Manager";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientLayout
            // 
            this.clientLayout.AutoScroll = true;
            this.clientLayout.Location = new System.Drawing.Point(14, 113);
            this.clientLayout.Margin = new System.Windows.Forms.Padding(5);
            this.clientLayout.Name = "clientLayout";
            this.clientLayout.Size = new System.Drawing.Size(954, 526);
            this.clientLayout.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.clientData11);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(752, 526);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // clientData11
            // 
            this.clientData11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.clientData11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientData11.CustomerAdress = "clientAdress";
            this.clientData11.CustomerName = "clientName";
            this.clientData11.CustomerPhone = "clientPhone";
            this.clientData11.Location = new System.Drawing.Point(3, 3);
            this.clientData11.Name = "clientData11";
            this.clientData11.RentedBooksCount = "clientBook";
            this.clientData11.Size = new System.Drawing.Size(723, 109);
            this.clientData11.TabIndex = 0;
            // 
            // loadMorebtn
            // 
            this.loadMorebtn.Location = new System.Drawing.Point(333, 16);
            this.loadMorebtn.Name = "loadMorebtn";
            this.loadMorebtn.Size = new System.Drawing.Size(75, 23);
            this.loadMorebtn.TabIndex = 0;
            this.loadMorebtn.Text = "loadMorebtn";
            this.loadMorebtn.UseVisualStyleBackColor = true;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.clientLayout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel clientLayout;
        private clientData1 clientData11;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button loadMorebtn;
        private System.Windows.Forms.Button editBookBtn;
        private System.Windows.Forms.Button editCusBtn;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchBtn;
    }
}