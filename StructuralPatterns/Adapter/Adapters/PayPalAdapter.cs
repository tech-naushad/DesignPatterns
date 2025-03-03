using StructuralPatterns.Adapter.Adaptees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.Adapters
{
    public class PayPalAdapter : IPaymentGateway
    {
        private readonly PayPal _adaptee;

        public PayPalAdapter(PayPal adaptee)
        {
            _adaptee = adaptee;
        }
        public void ProcessPayment(decimal amount)
        {
            _adaptee.SendPayment(amount);
        }
    }
}
