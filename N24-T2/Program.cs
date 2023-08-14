namespace N24_T2;

class Program
{
    static void Main(string[] args)
    {
        MovieService movieService = new MovieService();
        movieService.AddMovie("Eternal Echoes", "Samantha Carter", 8);
        movieService.AddMovie("Whispers in the Wind", "Benjamin Turner", 7);
        movieService.AddMovie("Midnight Serenade", "Emily Mitchell", 9);
        movieService.AddMovie("Forgotten Realms", "Alexander Roberts", 6);
        movieService.AddMovie("Starlit Secrets", "Olivia Parker", 8);
        movieService.AddMovie("Shadows of Yesterday", "Michael Hughes", 7);
        movieService.AddMovie("Dreams of Tomorrow", "Sophia Walker", 9);
        movieService.AddMovie("Echoes of Destiny", "Daniel Adams", 8);
        
        string searchKeyword = Console.ReadLine();
        List<Movie> searchResults = movieService.Search(searchKeyword);
        foreach (var movie in searchResults)
        {
            Console.WriteLine($"Nom: {movie.Name}, Avtor: {movie.Author}, Reyting: {movie.Rating}");
        }
    }
}