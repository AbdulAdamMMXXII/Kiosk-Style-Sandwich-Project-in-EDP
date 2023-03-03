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
    public partial class Form2Kiosk : Form
    {
        //Backwards reference to this form (FormKiosk1) instance in Form2Checkout when creating it.
        private ListBox.ObjectCollection selectedItems;
        private const int maxSize = 5;
        public Form2Kiosk()
        {
            InitializeComponent();
        }

        //This public method updates the selected items based on the ListBox in Form3Checkout.
        public void UpdateSelectedItems(ListBox.ObjectCollection selectedItems)
        {
            listItems.DataSource = null;
            listItems.Items.Clear();
            listItems.Items.AddRange(selectedItems);
        }
        private bool cartIsFull()
        {
            return listItems.Items.Count >= maxSize;
        }
        //Initialise button tuna sandwich
        private void btnTuna_Click(object sender, EventArgs e)
        {
            if (cartIsFull())
            {
                MessageBox.Show("You cart is full.");
                return;
            }
            double total = 0;
            total = (Convert.ToDouble(numTunaSanQTY.Value) * 3.49);
            listItems.Items.Add(numTunaSanQTY.Value + "X Tuna Sandwich " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
            //addtoTHE list();
        }

        //Calculate total
        private void btnTotal_Click(object sender, EventArgs e)
        {
            double tItems = 0;
            int noItems;
            noItems = Convert.ToInt32(listPrice.Items.Count);

            foreach (object item in listPrice.Items)
            {
                tItems += Convert.ToDouble(item.ToString());
            }
            lblTotal.Text = "£" + tItems.ToString();
        }

        //Initiliase remove item button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int SelectedIndex = listItems.SelectedIndex;
            listItems.Items.RemoveAt(SelectedIndex);
            listPrice.Items.RemoveAt(SelectedIndex);
        }

        //Commence checkout shopping button
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (listItems.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items before checking out.");
                return;
            }
            Form3Checkout Form3Checkout = new Form3Checkout(lblTotal.Text, listItems, this);
            Form3Checkout.Show();
            Hide();
        }

        private void btnSevenUp_Click(object sender, EventArgs e)
        {
            if (cartIsFull())
            {
                MessageBox.Show("Your cart is full.");
                return;
            }
            double total = 0;
            total = (Convert.ToDouble(num7UPDrinksQTY.Value) * 0.99);
            listItems.Items.Add(num7UPDrinksQTY.Value + "X 7UP " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnMixedSalad_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numMixedSaladQTY.Value) * 2.99);
            listItems.Items.Add(numMixedSaladQTY.Value + "X Mixed salad " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total); 
        }

        private void btnChocolateDessert_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numChocolateDessertQTY.Value) * 2.50);
            listItems.Items.Add(numChocolateDessertQTY.Value + "X Chocolate dessert " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        //Tab 1 Sandwiches
        private void btnBeefBurger_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numBeefBurgerQTY.Value) * 4.99);
            listItems.Items.Add(numBeefBurgerQTY.Value + "X Beef burger " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnHamSandwich_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numHamSandwichQTY.Value) * 3.99);
            listItems.Items.Add(numHamSandwichQTY.Value + "X Ham sandwich " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnSubmarineSandwich_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numSubmarineSandwichQTY.Value) * 4.50);
            listItems.Items.Add(numSubmarineSandwichQTY.Value + "X Submarine sandwich " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnCheeseAndSalad_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numCheeseAndSaladQTY.Value) * 3.00);
            listItems.Items.Add(numCheeseAndSaladQTY.Value + "X Cheese and salad " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnChickenSandwich_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numChickenSandwichQTY.Value) * 2.99);
            listItems.Items.Add(numChickenSandwichQTY.Value + "X Chicken sandwich " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        //Tab 2 Drinks
        private void btnAddOrangeJuice_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numOrangeJuiceQTY.Value) * 1.49);
            listItems.Items.Add(numOrangeJuiceQTY.Value + "X Glass of Orange juice " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnAddWater_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numBottleOfWaterQTY.Value) * 0.69);
            listItems.Items.Add(numBottleOfWaterQTY.Value + "X Bottle of water " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnAddCocacola_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numCocacolaQTY.Value) * 0.80);
            listItems.Items.Add(numCocacolaQTY.Value + "X Coca-cola drink " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnRedBull_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numRedBullQTY.Value) * 1.89);
            listItems.Items.Add(numRedBullQTY.Value + "X Red bull drink " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnFantaOrange_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numFantaOrangeQTY.Value) * 0.90);
            listItems.Items.Add(numFantaOrangeQTY.Value + "X Fanta orange drink " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        //Tab 3 Salads
        private void btnAddFruitSalad_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numFruitSaladQTY.Value) * 4.29);
            listItems.Items.Add(numFruitSaladQTY.Value + "X Fruit salad " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnAddVegetableSalad_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numVegetableSaladQTY.Value) * 3.00);
            listItems.Items.Add(numVegetableSaladQTY.Value + "X vegetable salad " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnAddFruitandVeggieSalad_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numFruitandVeggieQTY.Value) * 3.49);
            listItems.Items.Add(numFruitandVeggieQTY.Value + "X Fruit and vegetable salad " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnGreenSalad_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numGreenSaladQTY.Value) * 4.99);
            listItems.Items.Add(numGreenSaladQTY.Value + "X Green salad " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnChickenSalad_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numChickenSaladQTY.Value) * 4.00);
            listItems.Items.Add(numChickenSaladQTY.Value + "X Chicken salad " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        //Tab 4 Desserts 
        private void btnChocolateIceCream_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numChocolateIceCreamQTY.Value) * 3.99);
            listItems.Items.Add(numChocolateIceCreamQTY.Value + "X Chocolate ice cream dessert " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnCubeChocolate_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numCubeChocolateQTY.Value) * 2.99);
            listItems.Items.Add(numCubeChocolateQTY.Value + "X Cube chocolate dessert " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnCupcakeIcing_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numCupcakeIcingQTY.Value) * 3.49);
            listItems.Items.Add(numCupcakeIcingQTY.Value + "X Cupcake icing dessert " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnStrawberryAndMint_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numStrawberryAndMintQTY.Value) * 3.50);
            listItems.Items.Add(numStrawberryAndMintQTY.Value + "X Strawberry and mint " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }

        private void btnBirthdayCake_Click(object sender, EventArgs e)
        {
            double total = 0;
            total = (Convert.ToDouble(numBirthdayCakeQTY.Value) * 7.49);
            listItems.Items.Add(numBirthdayCakeQTY.Value + "X Birthday cake " + "£" + total);
            total = Math.Round(total, 2);
            listPrice.Items.Add(total);
        }
    }
}
