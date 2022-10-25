using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository
{
    public class DBContext : DbContext
    {
        public DbSet<Colour> color_tbl { get; set; }




        public DbSet<Product> tb1_product { get; set; }

        public DbSet<Article> tbl_article { get; set; }

        public DbSet<EntityLayer.Size> tb1_size { get; set; }
        public DbSet<Createcredit> tbl_createcredit { get; set; }
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {



        }
        




        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2151;Initial Catalog=ProductApi24a;Integrated Security=True;");
        }
    }

}