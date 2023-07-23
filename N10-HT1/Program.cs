using System;
using System.Collections.Generic;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}

public class LibraryManagement
{
    private Dictionary<int, int> Books; 

    public LibraryManagement()
    {
        Books = new Dictionary<int, int>();
    }

    public void AddBook(Book book, int numberOfCopies)
    {
        Books[book.Id] = numberOfCopies;
    }

    public bool Checkout(int bookId)
    {
        if (Books.ContainsKey(bookId))
        {
            if (Books[bookId] > 0)
            {
                Books[bookId]--; 
                return true;
            }
        }

        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book { Id = 1, Title = "To Kill a Mockingbird", Author = "Harper Lee" };
        Book book2 = new Book { Id = 2, Title = "1984", Author = "George Orwell" };
        Book book3 = new Book { Id = 3, Title = "Pride and Prejudice", Author = "Jane Austen" };

        LibraryManagement library = new LibraryManagement();
        library.AddBook(book1, 3);
        library.AddBook(book2, 5);
        library.AddBook(book3, 2);

        while (true)
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("1 - Checkout a book");
            Console.WriteLine("0 - Exit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Enter the book Id:");
                int bookId = int.Parse(Console.ReadLine());

                bool result = library.Checkout(bookId);
                if (result)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (input == "0")
            {
                Console.WriteLine("Exiting the program...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }

            Console.WriteLine();
        }
    }
}
