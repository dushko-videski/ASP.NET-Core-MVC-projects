using DataLayer.DomainModels;
using DataLayer.Interfaces;
using System.Collections.Generic;

namespace DataLayer.Repositories
{
    public class ProductRepository : IProductRepository
    {

        public List<Product> GetAll()
        {
            return DB.Products;
        }


        public void Insert(Product product)
        {
            DB.Products.Add(product);

        }

    }
}
