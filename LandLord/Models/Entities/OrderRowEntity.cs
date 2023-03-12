using System.ComponentModel.DataAnnotations;


namespace LandLord.Models.Entities;

internal class OrderRowEntity
{
    [Key]
    public int Id { get; set; }

    [StringLength(1000)]
    public string Description { get; set; } = null!;

    [Required]
    public int OrderId { get; set; }
    public OrderEntity Order { get; set; } = null!;

    public ICollection<CommentEntity> Comment = new HashSet<CommentEntity>();
}
