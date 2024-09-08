using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSmartInventorySystem
{
    public partial class AddBookForm : Form
    {
        private BookController _bookController;
        public AddBookForm(BookController bookController)
        {
            InitializeComponent();
            _bookController = bookController;
        }

        private void btn_Save(object sender, EventArgs e)
        {

        }

        private void txt_Title(object sender, EventArgs e)
        {

        }

        private void txt_Author(object sender, EventArgs e)
        {

        }

        private void txt_Genre(object sender, EventArgs e)
        {

        }

        private void txt_Stock(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_ReturnToInventory_Click(object sender, EventArgs e)
        {
            // Find the instance of InventoryForm or create a new one
            InventoryForm inventoryForm = Application.OpenForms.OfType<InventoryForm>().FirstOrDefault();

            if (inventoryForm == null)
            {
                // If InventoryForm is not open, create a new instance
                inventoryForm = new InventoryForm(_bookController);
            }

            // Show InventoryForm
            inventoryForm.Show();

            // Close AddBookForm
            this.Close();
        }
    }
}
