using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageProect.DataLayer.Entities;

public class PostComment : BaseEntity
{
   
    [Required] public string Text { get; set; }
    public int UserId { get; set; }
    public int PostId { get; set; }
    [ForeignKey("PostId")] public Post Post { get; set; }
    [ForeignKey("UserId")] public User User { get; set; }
    
}