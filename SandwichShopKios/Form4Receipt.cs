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
    public partial class Form4Receipt : Form
    {
        public Form4Receipt(string total, ListBox items_List)
        {
            InitializeComponent();
            lblTotal.Text = total;
            Items_List.Items.AddRange(items_List.Items);

            //Generate a reandom id and print on the shopping receipt
            Random generator = new Random();
            string shoppingReference = generator.Next(0, 1000000).ToString("D9");
            lblRefrenceDisplay.Text = shoppingReference.ToString();

            //Display the cureent day, date, month, year and time
            lblTimeDisplay.Text = DateTime.Now.ToString("dddd, d MMMM yyyy HH:mm:ss");
        }

        private void btnBuyAgain_Click(object sender, EventArgs e)
        {
            Form form1Home = new Form2Kiosk();
            form1Home.Show();
            Hide();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your receipt is printed! \nThanks for shopping at Mia's Sandwich Shop.");
        }
    }
}
