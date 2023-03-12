using System.ComponentModel.DataAnnotations;

namespace LandLord.Models.Entities;

internal class CommentEntity
{
    [Key]
    public int Id { get; set; }

    [StringLength(1000)]
    public string Description { get; set; } = null!;

    [Required]
    public int OrderRowId { get; set; }
    public OrderRowEntity OrderRow { get; set; } = null!;
}
