using DataLayer.Repository;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businese_Layer.Service
{
    public class SizeService
    {
        Isize _isize;
        public SizeService(Isize isize)
        {
            _isize = isize;
        }

        public void Addsize(Size size)
        {
            _isize.Addsize(size);
        }
        public void Editsize(Size size)
        {
            _isize.EditSize(size);
        }

        public void Removesize(int sizeId)
        {
            _isize.Removesize(sizeId);
        }

        public Size GetsizebyId(int sizeId)
        {
            return _isize.GetSizeById(sizeId);
        }

        public IEnumerable<Size> Getsizes()
        {
            return _isize.GetSizes();
        }
    }
}

