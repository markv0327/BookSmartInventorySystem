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
    public partial class InventoryForm : Form
    {
        private BookController _bookController;

        public InventoryForm(BookController bookController)
        {
            InitializeComponent();
            _bookController = bookController;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm(_bookController);
            addBookForm.Show();
        }

        private void btn_ReturnToMainForm_Click(object sender, EventArgs e)
        {
            // Check if Form1 is already open
            Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (mainForm == null)
            {
                // If Form1 is not open, create a new instance
                mainForm = new Form1();
            }

            // Show Form1
            mainForm.Show();

            // Close InventoryForm
            this.Close();
        }
    }
}
