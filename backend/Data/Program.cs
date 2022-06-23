using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data;

public class Program
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public virtual User? Manager { get; set; }
    public virtual ICollection<User> Students { get; set; } = new HashSet<User>();
    public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();

    private void EnrollStudent()
    {
        throw new NotImplementedException();
    }

    private void AssignManager()
    {
        throw new NotImplementedException();
    }
}