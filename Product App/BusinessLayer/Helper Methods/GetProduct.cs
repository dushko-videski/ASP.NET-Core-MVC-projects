using BusinessLayer.ViewModels;
using DataLayer.DomainModels;
using DataLayer.Interfaces;
using DataLayer.Repositories;

namespace BusinessLayer.Helper_Methods
{
    public static class GetProduct
    {
        private static IProductRepository _productRepository;

        static GetProduct()
        {
            _productRepository = new ProductRepository();
        }


        public static Product CreateProduct(CreateProductVM createProductVM)
        {
            return new Product()
            {
                Id = _productRepository.GetAll().Count + 1,
                Category = createProductVM.Category,
                Name = createProductVM.Name,
                Description = createProductVM.Description,
                Price = createProductVM.Price
            };
        }





    }
}
