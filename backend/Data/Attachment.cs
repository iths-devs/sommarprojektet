using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data;

public sealed class Attachment
{
    public int Id { get; set; }
    
    [Required]
    public StudentAssignment StudentAssignment { get; set; } = new();
    public string Content { get; set; } = string.Empty;
}