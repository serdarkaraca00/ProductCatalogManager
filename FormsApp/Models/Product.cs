using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Product Id")]
        public int ProductId { get; set; }
        
        [Required(ErrorMessage = "A required field")]
        [StringLength(100)]
        [Display(Name="Name of the product")]
        public string Name { get; set; } = null!;

        [Required]
        [Range(0, 100000)]
        [Display(Name="Price")]
        public decimal? Price { get; set; }

        [Display(Name="Picture")]
        public string? Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        [Display(Name="Category")]
        
        [Required]
        public int? CategoryId { get; set; }

    }
}