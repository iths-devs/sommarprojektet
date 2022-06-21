using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data;

public class Role
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    private Role(RoleName @enum)
    {
        Id = (int)@enum;
        Name = @enum.ToString();
    }

    protected Role() { } //For EF
    
    public static implicit operator Role(RoleName @enum) => new (@enum);

    public static implicit operator RoleName(Role role) => (RoleName)role.Id;
}