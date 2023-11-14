namespace DoAn.view
{
    partial class bookData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookImg = new System.Windows.Forms.PictureBox();
            this.Price = new System.Windows.Forms.Panel();
            this.nameNDesc = new System.Windows.Forms.Panel();
            this.hireBtn = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.quantLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookImg)).BeginInit();
            this.Price.SuspendLayout();
            this.nameNDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookImg
            // 
            this.bookImg.Location = new System.Drawing.Point(0, 0);
            this.bookImg.Name = "bookImg";
            this.bookImg.Size = new System.Drawing.Size(225, 235);
            this.bookImg.TabIndex = 0;
            this.bookImg.TabStop = false;
            // 
            // Price
            // 
            this.Price.Controls.Add(this.quantLabel);
            this.Price.Controls.Add(this.priceLabel);
            this.Price.Controls.Add(this.hireBtn);
            this.Price.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Price.Location = new System.Drawing.Point(0, 235);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(539, 98);
            this.Price.TabIndex = 1;
            // 
            // nameNDesc
            // 
            this.nameNDesc.Controls.Add(this.descLabel);
            this.nameNDesc.Controls.Add(this.titleLabel);
            this.nameNDesc.Dock = System.Windows.Forms.DockStyle.Right;
            this.nameNDesc.Location = new System.Drawing.Point(224, 0);
            this.nameNDesc.Name = "nameNDesc";
            this.nameNDesc.Size = new System.Drawing.Size(315, 235);
            this.nameNDesc.TabIndex = 2;
            // 
            // hireBtn
            // 
            this.hireBtn.Location = new System.Drawing.Point(421, 30);
            this.hireBtn.Name = "hireBtn";
            this.hireBtn.Size = new System.Drawing.Size(92, 35);
            this.hireBtn.TabIndex = 3;
            this.hireBtn.Text = "Hire Now";
            this.hireBtn.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(242, 32);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(56, 25);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(115, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(61, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.Location = new System.Drawing.Point(18, 76);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(140, 29);
            this.descLabel.TabIndex = 1;
            this.descLabel.Text = "Description";
            // 
            // quantLabel
            // 
            this.quantLabel.AutoSize = true;
            this.quantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantLabel.Location = new System.Drawing.Point(37, 32);
            this.quantLabel.Name = "quantLabel";
            this.quantLabel.Size = new System.Drawing.Size(85, 25);
            this.quantLabel.TabIndex = 5;
            this.quantLabel.Text = "Quantity";
            // 
            // bookData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameNDesc);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.bookImg);
            this.Name = "bookData";
            this.Size = new System.Drawing.Size(539, 333);
            ((System.ComponentModel.ISupportInitialize)(this.bookImg)).EndInit();
            this.Price.ResumeLayout(false);
            this.Price.PerformLayout();
            this.nameNDesc.ResumeLayout(false);
            this.nameNDesc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bookImg;
        private System.Windows.Forms.Panel Price;
        private System.Windows.Forms.Panel nameNDesc;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button hireBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label quantLabel;
    }
}
