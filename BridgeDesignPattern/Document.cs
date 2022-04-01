using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal class Document
    {
        public IFormat Format { get; set; }

        public Document(IFormat format)
        {
            Format = format;
        }

        public virtual void CreateFormat()
        {
            Format.Create();
        }
    }
}
