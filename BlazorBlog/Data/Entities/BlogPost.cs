using System.Linq.Expressions;

namespace BlazorBlog.Data.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Content { get; set; }
        public string Author { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
        public bool IsPublished { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public string Url { get; set; } = string.Empty;
    }

  
}
