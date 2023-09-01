using System.ComponentModel.DataAnnotations;

namespace N32_T6;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<Blog> initialBlogs = new List<Blog>
            {
                new Blog { Id = 0, Title = "First Blog", Body = "This is the body of the first blog." },
                new Blog { Id = 1, Title = "Second Blog", Body = "This is the body of the second blog." }
            };

            BlogService blogService = new BlogService(initialBlogs);

            blogService.Create(new Blog { Id = 2, Title = "Third Blog", Body = "This is the body of the third blog." });
            Blog retrievedBlog = blogService.Get(1);
            retrievedBlog.Body = "Updated body for the second blog.";
            blogService.Update(retrievedBlog);
            blogService.Delete(0);

            Blog nonExistingBlog = blogService.Get(10);
        }
        catch (ValidationException ex)
        {
            Console.WriteLine("Validation Exception: " + ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Argument Out Of Range Exception: " + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Invalid Operation Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}