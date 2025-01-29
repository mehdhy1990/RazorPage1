using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageProect.DataLayer.Entities;

public class Post : BaseEntity
{
    
    public int UserId { get; set; }
    public int CategoryId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }

   
    public int Visit { get; set; }
    [Required]
    public string slug { get; set; }
    [ForeignKey("UserId")] public User User { get; set; }
    [ForeignKey("CategoryId")] public Category Category { get; set; }
    public ICollection<PostComment> PostComments { get; set; }
}