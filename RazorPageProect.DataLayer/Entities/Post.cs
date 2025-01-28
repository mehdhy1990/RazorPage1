using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageProect.DataLayer.Entities;

public class Post
{
    public int  Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Visit { get; set; }
    public string slug { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
}