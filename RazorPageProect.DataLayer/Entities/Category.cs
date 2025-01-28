using System.Reflection;

namespace RazorPageProect.DataLayer.Entities;

public class Category
{
    public string Title { get; set; }
    public string Slug { get; set; }
    public string MetaTag { get; set; }
    public string  MetaDescription { get; set; }
}