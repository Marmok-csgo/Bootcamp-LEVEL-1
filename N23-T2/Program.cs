namespace N23_T2;

class Program
{
    static void Main()
    {
        List<Book> Books = new List<Book>();
        Books.Add(new Book("Sherlock Holms", 8, "Artur Conan Doyle"));
        Books.Add(new Book("Harry Potter", 9, "Jhon Rowley"));
        Books.Add(new Book("GameOfThrones", 7, "George Martin"));
        Books.Add(new Book("Dance with Dragons", 5, "George Martin"));
        Books.Add(new Book("Winds of Winter", 3, "George Martin"));
        
        
        
        Books
            .OrderByDescending(book => book.Rating)
            .ToList()
            .ForEach(book => Console.WriteLine($"{book.Name} - {book.Rating}"));


        var authorGroup = Books
            .GroupBy(book => book.Author)
            .Where(group => group.Count() > 1)
            .ToList();

        foreach (var group in authorGroup)
        {
            var authorName = group.Key;
            var bestBook = group.OrderByDescending(book => book.Rating).First();
            var worstBook = group.OrderByDescending(book => book.Rating).Last();

            Console.WriteLine($"\nAuthor: {authorName}\n" +
                              $"First: {bestBook.Name} (Rating: {bestBook.Rating})\n" +
                              $"Last: {worstBook.Name} (Rating: {worstBook.Rating})\n");
        }

    }
}

