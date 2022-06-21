using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data;

public class Enrollment
{
    public int Id { get; set; }
    
    [Required]
    public virtual Guid Student { get; set; }

    [Required]
    public virtual Course Course { get; set; } = new();

    public Grade Grade { get; set; } = Grade.None;
    public virtual ICollection<Assignment> Assignments { get; set; } = new HashSet<Assignment>();
}