using System.ComponentModel;
using System.Windows.Forms;

namespace DoAn.view
{
    public partial class clientData1 : UserControl
    {
        public clientData1()
        {
            InitializeComponent();
        }
        [Category("clientData")]
        public string CustomerName
        {
            get { return clientName.Text; }
            set { clientName.Text = value; }
        }

        [Category("clientData")]
        public string CustomerPhone
        {
            get { return clientPhone.Text; }
            set { clientPhone.Text = value; }
        }

        [Category("clientData")]
        public string RentedBooksCount
        {
            get { return clientBook.Text; }
            set { clientBook.Text = value; }
        }
    }
}
