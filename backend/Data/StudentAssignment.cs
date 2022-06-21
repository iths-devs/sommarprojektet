using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data;

public class StudentAssignment
{
    public int Id { get; set; }
    
    [Required]
    public virtual Assignment Assignment { get; set; } = new();
    
    [Required]
    public virtual Enrollment Enrollment { get; set; } = new();

    public Grade Grade { get; set; } = Grade.None;
    public virtual Attachment? Attachment { get; set; }
}