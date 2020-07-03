using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdersDll;

namespace DecoratorLabStarterCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new order
            Order order = new Order();

            // Express Shipping Decorator instance
            ExpressDeliveryOrderDecorator expressOrder = new ExpressDeliveryOrderDecorator(order);

            expressOrder.AddItem("BroncoHats", 2, 1.5, 0.2);
            expressOrder.AddItem("BroncoGloves", 1, 3.0, 0.5);
            expressOrder.AddItem("BroncoSocks", 6, 1.9, 0.1);
            expressOrder.AddItem("BroncoBanners", 3, 8.0, 1.5);
            expressOrder.AddItem("BroncoFootBalls", 4, 5.6, 0.6);
            expressOrder.AddItem("BroncoJerseys", 2, 2.3, 0.4);

            expressOrder.PrintOrderItems();

            // Visa Decorator instance
            VisaPaymentOrderDecorator visaOrder = new VisaPaymentOrderDecorator(order);
            visaOrder.PrintOrderItems();

            // American Express Decorator instance
            AmericanExpressPaymentOrderDecorator amexOrder = new AmericanExpressPaymentOrderDecorator(order);
            amexOrder.PrintOrderItems();

            Console.ReadLine();
        }
    }
}
