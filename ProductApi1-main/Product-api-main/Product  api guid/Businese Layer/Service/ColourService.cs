using DataLayer.Repository;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businese_Layer.Service
{
    public class ColourService
    {

        Icolour _icolor;
        public ColourService(Icolour icolor)
        {
            _icolor = icolor;
        }

        public void Addcolor(Colour color)
        {
            _icolor.AddColor(color);
        }
        public void Editcolor(Colour color)
        {
            _icolor.EditColor(color);
        }

        public void Removecolor(int colorId)
        {
            _icolor.RemoveColor(colorId);
        }

        public Colour GetcolorbyId(int colorId)
        {
            return _icolor.GetColorById(colorId);
        }

        public IEnumerable<Colour> Getcolors()
        {
            return _icolor.GetColors();
        }
    }
}
