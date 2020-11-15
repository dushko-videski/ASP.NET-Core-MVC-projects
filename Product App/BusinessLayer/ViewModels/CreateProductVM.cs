
using DataLayer.Enums;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.ViewModels
{
    public class CreateProductVM
    {
        [Required]
        [Display(Name = "Name of product:")]
        public string Name { get; set; }


        [Display(Name = "Price in US $:")]
        public double Price { get; set; }

        [Required]
        public string Description { get; set; }


        public ProductCategory Category { get; set; }

    }
}
