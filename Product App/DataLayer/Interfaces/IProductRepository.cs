using DataLayer.DomainModels;
using System.Collections.Generic;

namespace DataLayer.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        void Insert(Product product);

    }
}
