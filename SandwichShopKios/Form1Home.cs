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
    public partial class Form1Home : Form
    {
        Product sandwichesAdsImage, drinksAdsImage, saladsAdsImage, dessertsAdsImage;

        private void Form1Home_Load(object sender, EventArgs e)
        {
            picBSandwichesAds.Image = sandwichesAdsImage.image;
            picBDrindsAds.Image = drinksAdsImage.image;
            picBSaladsAds.Image = saladsAdsImage.image;
            picBDessertsAds.Image = dessertsAdsImage.image;
        }

        public Form1Home()
        {
            InitializeComponent();
            ProductsAdvertisementImages();
        }

        private void ProductsAdvertisementImages()
        {
            sandwichesAdsImage = new Product();
            sandwichesAdsImage.image = Image.FromFile("SandwichAdsics.png");

            drinksAdsImage = new Product();
            drinksAdsImage.image = Image.FromFile("Fizzyandnaturaldrinks.png");

            saladsAdsImage = new Product();
            saladsAdsImage.image = Image.FromFile("SaladsAdspic.png");

            dessertsAdsImage = new Product();
            dessertsAdsImage.image = Image.FromFile("DessertsAdspic.png");
        }

        private void btnForm2Kiosk_Click(object sender, EventArgs e)
        {
            Form2Kiosk form2Kiosk = new Form2Kiosk();
            form2Kiosk.Show();
            Hide();
        }
    }
}
