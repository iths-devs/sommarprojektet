using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data;

public class User
{
    public Guid Id { get; set; }
    public virtual ICollection<Role> Roles { get; set; } = new HashSet<Role>();
}