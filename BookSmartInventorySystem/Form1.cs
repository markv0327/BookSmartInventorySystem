using System;
using System.Windows.Forms;

namespace BookSmartInventorySystem
{
    public partial class Form1 : Form

    {

        private BookRepository bookRepository;
        private BookController _bookController;

        public Form1()
        {
            InitializeComponent();
            //bookRepository = new BookRepository();


            bookRepository = new BookRepository();
            _bookController = new BookController();

            LoadBooks();
        }

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(_bookController);
            inventoryForm.Show();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadBooks()
        {
            if (bookRepository != null)
            {
                List<Book> books = bookRepository.GetBooks(); // Fetch list of books from the database
                dataGridView1.DataSource = books;
            }
            else
            {
                MessageBox.Show("Error: Book repository is not initialized.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _bookController.LoadBooksToForm1();
        }

        public void UpdateBookGrid(List<Book> books)
        {
            dataGridView1.DataSource = books;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
