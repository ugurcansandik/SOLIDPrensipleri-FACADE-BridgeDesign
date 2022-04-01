using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal class SalesDocument : Document
    {
        public SalesDocument(IFormat format) : base(format)
        {
            //constructor
        }

        public override void CreateFormat()
        {
            //ekstra olarak bir şey yapmak istersek burada yapıyoruz 
            base.CreateFormat();
        }
    }
}
