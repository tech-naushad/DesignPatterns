﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.Adaptees
{
    public class WePay
    {
        public void SendPayment(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} processed via WePay.");
        }
    }
}
