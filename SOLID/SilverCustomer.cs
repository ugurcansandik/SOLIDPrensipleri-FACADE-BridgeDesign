﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class SilverCustomer : ICustomer
    {
        public void Pay()
        {
            //ödeme yapmadan geçme şansı olmadığı için sadece bu fonksiyon var
        }
    }
}
