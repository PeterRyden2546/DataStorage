using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LandLord.Models.Entities;
[Index(nameof(Email), IsUnique = true)]
internal class EmployeEntity
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [Column(TypeName = "char(13)")]
    public string PhoneNumber { get; set; } = null!;

    [StringLength(70)]
    public string Email { get; set; } = null!;

    [Required]
    public int RoleId { get; set; }
    public RoleEntity Role { get; set; } = null!;

    public ICollection<OrderEntity> Orders = new HashSet<OrderEntity>();
}
