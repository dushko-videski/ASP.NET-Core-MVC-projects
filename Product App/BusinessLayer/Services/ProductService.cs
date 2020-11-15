using BusinessLayer.DataTransferModels;
using BusinessLayer.Helper_Methods;
using BusinessLayer.Helpers;
using BusinessLayer.Interfaces;
using BusinessLayer.ViewModels;
using DataLayer.DomainModels;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }


        //#########################################

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        //==============================================================
        public void InsertProduct(Product product)
        {
            _productRepository.Insert(product);
        }

        //==============================================================
        public ProductVM GetProductVMByID(int id)
        {
            List<ProductVM> listOfProductVM = GetAllProductVM.GetListOfProductVM();


            return listOfProductVM.SingleOrDefault(pvm => pvm.Id == id);
        }

        //==============================================================
        public List<ProductDto> GetListOfProductDto()
        {
            return GetAllProductDto.GetListOfProductDto();
        }


        //==============================================================
        public ProductListVM GetProductListVM()
        {
            List<ProductVM> listOfProductVM = GetAllProductVM.GetListOfProductVM();

            ProductListVM productListVM = new ProductListVM()
            {
                TotalNumberOfProducts = listOfProductVM.Count,
                Products = listOfProductVM
            };

            return productListVM;
        }


        //==============================================================
        public Product CreateProduct(CreateProductVM createProductVM)
        {
            return GetProduct.CreateProduct(createProductVM);
        }

        //=============================================================

        public Product CreateProductFromProductVM(ProductVM productVM)
        {
            return GetProductFromProductVM.CreateProductFromProductVM(productVM);

        }


    }
}
