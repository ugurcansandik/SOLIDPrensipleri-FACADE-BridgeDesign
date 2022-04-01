using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal abstract class IFileSave
    {
        public abstract void SaveToFile(Customer customer);
    }
}
