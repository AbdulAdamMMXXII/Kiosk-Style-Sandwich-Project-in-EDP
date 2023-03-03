using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandwichShopKios
{
    public partial class Form3Checkout : Form
    {
        private Form2Kiosk Form2Kiosk;
        private ListBox.ObjectCollection selectedItems;
        public Form3Checkout(string total, ListBox items_list, Form2Kiosk form2Kiosk)
        {
            InitializeComponent();
            lblTotalPrice.Text = total;
            lstBReviewItems.Items.AddRange(items_list.Items);

            //Generate a reandom 4 digits and represent to the payment card's last digits
            Random generator = new Random();
            string shoppingReference = generator.Next(0, 1000).ToString("D4");
            lblLast4Digits.Text = shoppingReference.ToString();
            Form2Kiosk = form2Kiosk;
        }
        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            Form4Receipt form3Receipt = new Form4Receipt(lblTotalPrice.Text, lstBReviewItems);
            form3Receipt.Show();
            this.Hide();
        }

        private void btnBackwards_Click(object sender, EventArgs e)
        {
            selectedItems = lstBReviewItems.Items;
            Form2Kiosk.UpdateSelectedItems(selectedItems);
            Form2Kiosk.Show();
            this.Hide();
        }
    }
}
