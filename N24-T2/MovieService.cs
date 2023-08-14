namespace N24_T2;

public class MovieService
{
    private List<Movie> movies = new List<Movie>();

    public List<Movie> Search(string search)
    {
        return movies.Where(movie =>
            movie.Name.ToLower().Contains(search.ToLower()) ||
            movie.Author.ToLower().Contains(search.ToLower()))
            .ToList();
    }
    
    
    public void AddMovie(string name, string author, double rating)
    {
        movies.Add(new Movie{Name = name, Author = author, Rating = rating});
        
    }
}