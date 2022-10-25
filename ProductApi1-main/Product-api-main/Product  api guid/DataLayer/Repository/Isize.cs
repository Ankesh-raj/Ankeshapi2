using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;

namespace DataLayer.Repository
{
    public interface Isize
    {
        void Addsize(Size size);

        void Removesize(int sizeId);

        void EditSize(Size size);

        Size GetSizeById(int sizeId);

        IEnumerable<Size> GetSizes();
    }
}

