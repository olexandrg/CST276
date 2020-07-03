using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDll
{
    public class AmericanExpressPaymentOrderDecorator : OrderDecorator
    {
        public AmericanExpressPaymentOrderDecorator(AbstractOrderBase order) : base(order) {}
        public override void PrintOrderItems()
        {
            Console.WriteLine("Additional Charges May Apply");
            base.PrintOrderItems();
            Console.WriteLine("Grand Total with American Express Charge {0:C}", GetTotalCost());
            Console.WriteLine();
        }
        public override double GetTotalCost()
        {
            return base.GetTotalCost() + 5.00;
        }
    }
}
