using DataLayer.Enums;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
        [Required]
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
    }
}
