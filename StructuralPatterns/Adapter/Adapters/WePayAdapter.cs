using StructuralPatterns.Adapter.Adaptees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.Adapters
{
    public class WePayAdapter : IPaymentGateway
    {
        private readonly WePay _adaptee;

        public WePayAdapter(WePay adaptee)
        {
            _adaptee = adaptee;
        }
        public void ProcessPayment(decimal amount)
        {
            _adaptee.SendPayment(amount);
        }
    }
}
