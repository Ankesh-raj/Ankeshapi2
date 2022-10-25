using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository
{
    public interface Iproduct
    {
        void AddProduct(Product product);

        void RemoveProduct(int productId);

        void EditProduct(Product product);

        Product GetProductById(int productId);

        IEnumerable<Product> GetProducts();
        void GenerateProductCode(Product product, out string productCode);

    }
}

