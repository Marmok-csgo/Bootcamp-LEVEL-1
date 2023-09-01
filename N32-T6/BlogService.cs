using System.ComponentModel.DataAnnotations;

namespace N32_T6;

class BlogService
{
    private List<Blog> _blogs;

    public BlogService(List<Blog> initialBlogs)
    {
        _blogs = initialBlogs;
    }

    public void Create(Blog model)
    {
        if (model == null || string.IsNullOrEmpty(model.Title) || string.IsNullOrEmpty(model.Body))
        {
            throw new ValidationException("Invalid model data");
        }
        _blogs.Add(model);
    }

    public Blog Get(int id)
    {
        var blog = _blogs.FirstOrDefault(b => b.Id == id);
        if (blog == null)
        {
            throw new ArgumentOutOfRangeException("Invalid id");
        }
        return blog;
    }

    public void Update(Blog model)
    {
        if (model == null || string.IsNullOrEmpty(model.Title) || string.IsNullOrEmpty(model.Body))
        {
            throw new ValidationException("Invalid model data");
        }

        var existingBlog = _blogs.FirstOrDefault(b => b.Id == model.Id);
        if (existingBlog == null)
        {
            throw new InvalidOperationException("Model not found");
        }

        existingBlog.Title = model.Title;
        existingBlog.Body = model.Body;
    }

    public void Delete(int id)
    {
        var blog = _blogs.FirstOrDefault(b => b.Id == id);
        if (blog == null)
        {
            throw new ArgumentOutOfRangeException("Invalid id");
        }

        _blogs.Remove(blog);
    }
}