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
    public partial class bookData : UserControl
    {
        public bookData()
        {
            InitializeComponent();
        }
        [Category("bookData")]
        public void SetBookData(string title, string description, decimal price, int quantity, string image)
        {
            titleLabel.Text = title;
            descLabel.Text = description;
            priceLabel.Text = $"Price: {price:C}";
            quantLabel.Text = $"Quantity: {quantity}";

            if (image != null && image.Length > 0)
            {
                bookImg.Image = Image.FromFile(image);
                bookImg.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
