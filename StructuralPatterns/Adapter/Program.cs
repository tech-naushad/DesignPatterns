using StructuralPatterns.Adapter.Adaptees;
using StructuralPatterns.Adapter.Adapters;

namespace StructuralPatterns.Adapter
{
    class Program
    {
        static void Main()
        {
            IPaymentGateway paypalGateway = new PayPalAdapter(new PayPal());
            paypalGateway.ProcessPayment(100);

            IPaymentGateway wePayGateway = new WePayAdapter(new WePay());
            wePayGateway.ProcessPayment(200);
        }
    }
}
