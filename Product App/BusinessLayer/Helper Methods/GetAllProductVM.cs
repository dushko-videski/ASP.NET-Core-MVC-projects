using BusinessLayer.ViewModels;
using DataLayer.DomainModels;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using System.Collections.Generic;

namespace BusinessLayer.Helpers
{

    public static class GetAllProductVM
    {
        private static IProductRepository _productRepository;

        static GetAllProductVM()
        {
            _productRepository = new ProductRepository();
        }


        public static List<ProductVM> GetListOfProductVM()
        {
            List<ProductVM> listOfProductVM = new List<ProductVM>();

            foreach (Product product in _productRepository.GetAll())
            {
                ProductVM productVM = new ProductVM()
                {
                    Id = product.Id,
                    Category = product.Category,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price
                };
                listOfProductVM.Add(productVM);
            }

            return listOfProductVM;
        }




    }
}
