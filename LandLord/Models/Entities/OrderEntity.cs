using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LandLord.Models.Entities;

internal class OrderEntity
{
    [Key]
    public int Id { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Required]
    public int TenantId { get; set; }

    [Required]
    public int EmployeId { get; set; }

    public TenantEntity Order { get; set; } = null!;
    public EmployeEntity Orders { get; set; } = null!;
    public ICollection<OrderRowEntity> OrderRow = new HashSet<OrderRowEntity>();
}
