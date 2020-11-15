using System.Collections.Generic;

namespace BusinessLayer.ViewModels
{
    public class ProductListVM
    {
        public int TotalNumberOfProducts { get; set; }
        public List<ProductVM> Products { get; set; }
    }
}
