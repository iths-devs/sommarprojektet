using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public GradeScale GradeScale { get; set; }
    public virtual User? Manager { get; set; }
    public virtual ICollection<User> Teachers { get; set; } = new HashSet<User>();
    public virtual ICollection<Enrollment> Enrollments { get; set; } = new HashSet<Enrollment>();
    public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    public virtual ICollection<Assignment> Assignments { get; set; } = new HashSet<Assignment>();

    public void GetCourseLength()
    {
        throw new NotImplementedException();
    }

    public void EnrollStudent(int userId)
    {
        throw new NotImplementedException();
    }

    public void AssignTeacher(int userId)
    {
        throw new NotImplementedException();
    }
}