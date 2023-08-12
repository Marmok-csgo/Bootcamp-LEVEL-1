namespace temp_4;

class Program
{
    static void Main()
    {
        List<Book> libraryBooks = GetLibraryBooks();
        int targetYear = 2010;

        var recentBooks = from book in libraryBooks
            where book.PublishYear > targetYear
            select book;


        foreach (var book in recentBooks)
        {
            Console.WriteLine($"{book.Title} - ({book.PublishYear})");
        }
    }


    static List<Book> GetLibraryBooks()
    {
        List<Book> books = new List<Book>
        {
            new Book { Title = "Book_1", PublishYear = 2005 },
            new Book { Title = "Book_2", PublishYear = 2009 },
            new Book { Title = "Book_3", PublishYear = 2012 },
            new Book { Title = "Book_4", PublishYear = 2015 },
            new Book { Title = "Book_5", PublishYear = 2019 }
        };

        return books;
    }
}

