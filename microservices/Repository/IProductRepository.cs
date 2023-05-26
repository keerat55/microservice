using microservices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace microservices.Repository
{
    interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        IProductRepository GetProductByID(int ProductId);
        void InsertProduct(Product Product);
        void DeleteProduct(int ProductId);
        void UpdateProduct(Product Product);
        void Save();

    }
}
