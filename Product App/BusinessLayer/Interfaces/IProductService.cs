using BusinessLayer.DataTransferModels;
using BusinessLayer.ViewModels;
using DataLayer.DomainModels;
using System.Collections.Generic;

namespace BusinessLayer.Interfaces
{
    public interface IProductService
    {

        List<Product> GetAllProducts();

        void InsertProduct(Product product);

        ProductVM GetProductVMByID(int id);

        List<ProductDto> GetListOfProductDto();

        ProductListVM GetProductListVM();

        Product CreateProduct(CreateProductVM createProductVM);

        Product CreateProductFromProductVM(ProductVM productVM);

    }
}
