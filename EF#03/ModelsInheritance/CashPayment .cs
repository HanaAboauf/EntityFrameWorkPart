﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.ModelsInheritance
{
    internal class CashPayment:Payment
    {
        public string Currency { get; set; }
    }
}
