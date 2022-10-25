using DataLayer.Repository;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businese_Layer.Service
{
    public class ProductService
    {
        Iproduct _productRepo;

        DBContext _productDbContext;


        public ProductService(Iproduct productRepo, DBContext productDbContext)
        {
            _productRepo = productRepo;
            _productDbContext = productDbContext;
        }

        public void AddProduct(Product product)
        {


            _productRepo.AddProduct(product);
            string productCode = string.Empty;
            _productRepo.GenerateProductCode(product, out productCode);
            product.productCode = productCode;
            _productDbContext.tb1_product.Add(product);
            _productDbContext.SaveChangesAsync();

        }
        public void EditProduct(Product Product)
        {
            _productRepo.EditProduct(Product);
        }

        public void RemoveProduct(int productId)
        {
            _productRepo.RemoveProduct(productId);
        }

        public Product GetProductbyId(int productId)
        {
            return _productRepo.GetProductById(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepo.GetProducts();
        }
    }
}
