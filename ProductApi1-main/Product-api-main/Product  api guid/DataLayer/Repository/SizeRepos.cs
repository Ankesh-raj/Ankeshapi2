using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repository
{
    public class SizeRepost : Isize
    {
        DBContext _dbContext;
        public SizeRepost(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void Addsize(Size size)
        {
            _dbContext.tb1_size.Add(size);
            _dbContext.SaveChanges();
        }

      

        public void EditSize(Size size)
        {
            _dbContext.Entry(size).State = EntityState.Modified;

            _dbContext.SaveChanges();

        }

       

        public Size GetSizeById(int sizeId)
        {
            return _dbContext.tb1_size.Find(sizeId);
        }

        public IEnumerable<Size> GetSizes()
        {
            return _dbContext.tb1_size.ToList();
        }

        public void Removesize(int sizeId)
        {
            var size = _dbContext.tb1_size.Find(sizeId);
            _dbContext.tb1_size.Remove(size);
            _dbContext.SaveChanges();
        }

        Size Isize.GetSizeById(int sizeId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Size> Isize.GetSizes()
        {
            return _dbContext.tb1_size.ToList();
        }
    }
}