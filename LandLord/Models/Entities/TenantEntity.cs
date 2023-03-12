using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LandLord.Models.Entities;

internal class TenantEntity
{
    [Key]
    public int Id { get; set; }
    [StringLength(50)]
    public string FirstName { get; set; } = null!;
    [StringLength(50)]
    public string LastName { get; set; } = null!;
    [Column(TypeName = "char(13)")]
    public string PhoneNumber { get; set; } = null!;
    [Column(TypeName = "varchar(70)")]
    public string Email { get; set; } = null!;
    [Required]
    public int ApartmentId { get; set; }
    public ICollection<ApartmentEntity> Customer = new HashSet<ApartmentEntity>();
}
