﻿using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace RazorPageProect.DataLayer.Entities;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Slug { get; set; }
    public string MetaTag { get; set; }
    public string  MetaDescription { get; set; }
    public ICollection<Post> Posts { get; set; }

    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }
}