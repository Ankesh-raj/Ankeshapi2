using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository
{
    public  interface Icolour
    {
        void AddColor(Colour colour);

        void RemoveColor(int colourId);

        void EditColor(Colour colour);

        Colour GetColorById(int colourId);

        IEnumerable<Colour> GetColors();
    }
}
