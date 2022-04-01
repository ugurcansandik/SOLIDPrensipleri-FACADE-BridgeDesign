using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class ExcelFile : IFileSave, IFileRead
    {
        public void ReadToFile()
        {
            //read to excel file
        }

        public override void SaveToFile(Customer customer)
        {
            //save excel file
        }
    }
}
