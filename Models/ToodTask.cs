using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToodList.Data;

namespace ToodList.Models;

public class ToodTask
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public required string Name { get; set; }
    public required string Description { get; set; }
    public bool IsCompleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public required string CreatedById { get; set; }

    [ForeignKey(nameof(CreatedById))]
    public ApplicationUser CreatedBy { get; set; } = null!;

    [ForeignKey(nameof(UpdatedById))]
    public required string UpdatedById { get; set; }

    public ApplicationUser UpdatedBy { get; set; } = null!;
}