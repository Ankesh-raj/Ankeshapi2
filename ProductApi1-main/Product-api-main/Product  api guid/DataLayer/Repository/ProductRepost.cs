using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repository
{
    public class ProductRepost : Iproduct
    {

        DBContext _dbContext;
        public ProductRepost(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void AddProduct(Product Product)
        {
            Guid id = Guid.NewGuid();
            Product.productId = id;

            _dbContext.tb1_product.Add(Product);
            _dbContext.SaveChanges();
        }



        public void EditProduct(Product Product)
        {
            _dbContext.Entry(Product).State = EntityState.Modified;

            _dbContext.SaveChanges();

        }

        public Product GetProductById(int productId)
        {
            return _dbContext.tb1_product.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.tb1_product.ToList();
        }

        public void RemoveProduct(int productId)
        {
            var Product = _dbContext.tb1_product.Find(productId);
            _dbContext.tb1_product.Remove(Product);
            _dbContext.SaveChanges();
        }
        private static int channel1Code = 001;
        private static long channel3Code = 10000000;
        private static Random random = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public void GenerateProductCode(Product product, out string code)
        {
            code = ComputeCode(product);

            while (CheckIfUnique(code))
            {
                code = ComputeCode(product);
            }
        }

        private string ComputeCode(Product product)
        {
            string code;

            switch (product.channelId)
            {
                //productYear + three digit integer code(2022001)
                case 1:
                    code = $"{product.productYear}00{channel1Code}";
                    channel1Code++;
                    break;
                // 6 digit unique alphanumeric code 
                case 2:
                    code = AlphanumericGenerator(6);
                    break;
                //integer which increases sequencially
                case 3:
                    code = $"{channel3Code}";
                    channel3Code++;
                    break;

                default: code = "Invalid Code"; break;
            }
            return code;
        }
        private bool CheckIfUnique(string code)
        {
            return _dbContext.tb1_product.Any(x => x.productCode == code);
        }
        private string AlphanumericGenerator(int length)
        {
            var result = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return result;
        }

    }
}



