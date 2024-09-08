

//this handles the CRUD operations and retrieves and updates data in the database
//had to install NuGet Package Manager System.Data.SqlClient

using BookSmartInventorySystem;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class BookRepository
{
    //private string connectionString = "Server=localhost;Database=BookSmartDB;Trusted_Connection=True;";
    private string connectionString = "Server=DESKTOP-1UT63KC\\SQLEXPRESS;Database=BookSmartDB;Trusted_Connection=True;";

    public List<Book> GetBooks()
    {
        List<Book> books = new List<Book>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Book book = new Book
                {
                    BookID = (int)reader["BookID"],
                    Title = reader["Title"].ToString(),
                    Author = reader["Author"].ToString(),
                    Genre = reader["Genre"].ToString(),
                    Location = reader["Location"].ToString(),
                    Stock = (int)reader["Stock"],
                    Price = (decimal)reader["Price"]
                };
                books.Add(book);
            }
        }

        return books;
    }

    public List<string> GetBookTitles()
    {
        List<string> bookTitles = new List<string>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT Title FROM Books";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                bookTitles.Add(reader["Title"].ToString());
            }

            reader.Close();
        }

        return bookTitles;
    }


    public void AddBook(Book book)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Books (Title, Author, Genre, Location, Stock, Price) VALUES (@Title, @Author, @Genre, @Location, @Stock, @Price)", conn);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Author", book.Author);
            cmd.Parameters.AddWithValue("@Genre", book.Genre);
            cmd.Parameters.AddWithValue("@Location", book.Location);
            cmd.Parameters.AddWithValue("@Stock", book.Stock);
            cmd.Parameters.AddWithValue("@Price", book.Price);

            cmd.ExecuteNonQuery();
        }
    }

    public void UpdateBook(Book book)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "UPDATE Books SET Title = @Title, Author = @Author, Genre = @Genre, Location = @Location, Stock = @Stock, Price = @Price WHERE BookID = @BookID";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BookID", book.BookID);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Genre", book.Genre);
                cmd.Parameters.AddWithValue("@Location", book.Location);
                cmd.Parameters.AddWithValue("@Stock", book.Stock);
                cmd.Parameters.AddWithValue("@Price", book.Price);

                cmd.ExecuteNonQuery();
            }
        }
    }

    public void DeleteBook(int bookID)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "DELETE FROM Books WHERE BookID = @BookID";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.ExecuteNonQuery();
            }
        }
    }


}
