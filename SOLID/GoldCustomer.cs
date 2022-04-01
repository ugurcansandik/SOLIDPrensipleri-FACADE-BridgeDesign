using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class GoldCustomer : INoPay, ICustomer
    {
        public void NoPay()
        {
            //gold üye olduğu için ödeme yapmadan geçme şansı var
        }

        public void Pay()
        {
            //ödeme de yapabilir
        }
    }
}
