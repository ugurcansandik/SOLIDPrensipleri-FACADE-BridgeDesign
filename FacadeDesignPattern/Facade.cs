using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    internal class Facade
    {
        public IGraphicCard _graphicCard;
        public IGraphicCardBrand _graphicCardBrand;

        public Facade()
        {
            _graphicCard = new GraphicCard();
            _graphicCardBrand = new GraphicCardBrand();
        }
    }
}
