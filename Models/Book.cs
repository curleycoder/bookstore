using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Models;

public class Book
{
    public int Id { get; set; }
    
    [Required]
    public string Title { get; set; } = string.Empty;

    [Display(Name = "Cover Image")]
    public string CoverImageUrl { get; set; } = string.Empty;

    [Required]
    public string Author { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;

    [Display(Name = "Publication Year")]
    public int PublicationYear { get; set; }
    public string Language { get; set; } = string.Empty;
    public int PageCount { get; set; }

    [Range(0, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}