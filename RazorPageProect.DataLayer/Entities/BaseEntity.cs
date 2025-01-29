using System.ComponentModel.DataAnnotations;

namespace RazorPageProect.DataLayer.Entities;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }
}