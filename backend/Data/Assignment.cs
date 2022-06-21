using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data;

public class Assignment
{
    public int Id { get; set; }
    
    [Required]
    public virtual Course Course { get; set; } = new();
    
    public AssignmentType AssignmentType { get; set; }
    public bool Graded { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    
    public virtual ICollection<StudentAssignment> StudentAssignments { get; set; } = new HashSet<StudentAssignment>();
}