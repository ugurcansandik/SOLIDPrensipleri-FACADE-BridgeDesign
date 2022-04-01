using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class TextFile : IFileSave, IFileRead
    {
        public void ReadToFile()
        {
            //read text file
        }

        public override void SaveToFile(Customer customer)
        {
            //save text file
        }
    }
}
