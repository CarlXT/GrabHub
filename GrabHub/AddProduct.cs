using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabHub
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    public partial class AddProduct : Form
    {
        public static List<Product> orderedProducts = new List<Product>();

        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxQuantity_Click(object sender, EventArgs e)
        {
            if (txtBoxQuantity.Text.Equals("Quantity") || txtBoxQuantity.Text.Equals("Error!") || txtBoxQuantity.Text.Equals("Success"))
            {
                txtBoxQuantity.Text = "";
            }
        }

        private void txtBoxQuantity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxQuantity.Text) || txtBoxQuantity.Text == "Error!")
            {
                txtBoxQuantity.Text = "Quantity"; // Reset only if it's empty or an error
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();  // Close AddProduct form
            if (this.Owner != null) // If the original MainMenu exists
            {
                this.Owner.Show();  // Show the original MainMenu instead of creating a new one
            }
        }

        private void orange1_Load(object sender, EventArgs e)
        {

        }

        private void mainbtn_Click(object sender, EventArgs e)
        {
            txtBoxQuantity.Text = txtBoxQuantity.Text.Trim();

            bool isChecked = chkBoxApple.Checked || chkBoxBanana.Checked ||
                             chkBoxEggplant.Checked || chkBoxHorseradish.Checked ||
                             chkBoxOrange.Checked;

            // Ensure the quantity is a valid integer greater than 0
            bool isQuantityValid = int.TryParse(txtBoxQuantity.Text, out int quantity) && quantity > 0;

            // If no checkboxes are checked or quantity is invalid, show an error and stop execution
            if (!isChecked || !isQuantityValid)
            {
                txtBoxQuantity.Text = "Error!";
                return; // Exit the function early
            }

            // If all conditions are met, set success message before adding products
            txtBoxQuantity.Text = "Success";

            // Add selected products to the order list
            if (chkBoxApple.Checked) orderedProducts.Add(new Product("Apple", 50.00, quantity));
            if (chkBoxBanana.Checked) orderedProducts.Add(new Product("Banana", 30.00, quantity));
            if (chkBoxEggplant.Checked) orderedProducts.Add(new Product("Eggplant", 20.00, quantity));
            if (chkBoxHorseradish.Checked) orderedProducts.Add(new Product("Horseradish", 45.00, quantity));
            if (chkBoxOrange.Checked) orderedProducts.Add(new Product("Orange", 25.00, quantity));
        }

        private void txtBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers (0-9) and control keys (like Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block input
            }
        }
    }
}
