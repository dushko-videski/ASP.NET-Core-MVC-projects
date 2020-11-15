using BusinessLayer.ViewModels;
using DataLayer.DomainModels;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using System.Linq;

namespace BusinessLayer.Helper_Methods
{
    public static class GetProductFromProductVM
    {
        private static IProductRepository _productRepository;

        static GetProductFromProductVM()
        {
            _productRepository = new ProductRepository();
        }

        public static Product CreateProductFromProductVM(ProductVM productVM)
        {
            Product product = _productRepository.GetAll().SingleOrDefault(p => p.Id == productVM.Id);

            product.Name = productVM.Name;
            product.Price = productVM.Price;
            product.Description = productVM.Description;
            product.Category = productVM.Category;

            return product;
        }




    }
}
