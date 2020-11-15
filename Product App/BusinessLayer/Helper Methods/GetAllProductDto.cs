using BusinessLayer.DataTransferModels;
using DataLayer.DomainModels;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Helper_Methods
{
    static class GetAllProductDto
    {
        private static IProductRepository _productRepository;


        static GetAllProductDto()
        {
            _productRepository = new ProductRepository();
        }

        public static List<ProductDto> GetListOfProductDto()
        {
            List<ProductDto> listOfProductDto = new List<ProductDto>();

            foreach (Product product in _productRepository.GetAll())
            {
                ProductDto productDto = new ProductDto()
                {
                    Id = product.Id,
                    SerialNo = Convert.ToString($"{new Random().Next(1, 1000000)}_{product.Id}"),
                    Category = product.Category,
                    Description = product.Description,
                    Name = product.Name,
                    Price = product.Price
                };
                listOfProductDto.Add(productDto);
            }
            return listOfProductDto;
        }


    }
}
