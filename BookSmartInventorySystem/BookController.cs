using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient; // Ensure you have this namespace for SQL connection
using System.Data; // This is needed for working with DataTables

namespace BookSmartInventorySystem
{
    public class BookController
    {
        private readonly BookRepository _bookRepository;
        private readonly BookRepository bookRepository;
        private readonly Form1 _form1;
        private readonly InventoryForm _inventoryForm;

        private string _connectionString;

        public BookController()
        {
            // Set your connection string here (make sure it's valid and points to your SQL Server)
            _connectionString = "Server=localhost;Database=BookSmartDB;Trusted_Connection=True;";
        }

        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public BookController(Form1 form1, InventoryForm inventoryForm)
        {
            _bookRepository = new BookRepository();
            _form1 = form1;
            _inventoryForm = inventoryForm;
        }

        public void LoadBooksToForm1()
        {
            var books = _bookRepository.GetBooks();
            _form1.UpdateBookGrid(books);
        }

        public void OpenInventoryForm()
        {
            _inventoryForm.Show();
        }

        public List<Book> GetBooks()
        {
            return _bookRepository.GetBooks();
        }

        public List<string> GetBookTitles()
        {
            return bookRepository.GetBookTitles();
        }


        public void AddBook(Book book)
        {
            _bookRepository.AddBook(book);
            LoadBooksToForm1(); // Refresh data on Form1
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.UpdateBook(book);
            LoadBooksToForm1(); // Refresh data on Form1
        }

        public void DeleteBook(int bookID)
        {
            _bookRepository.DeleteBook(bookID);
            LoadBooksToForm1(); // Refresh data on Form1
        }
    }
}
