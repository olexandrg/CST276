using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDll
{
    public class ExpressDeliveryOrderDecorator : OrderDecorator
    {
        public ExpressDeliveryOrderDecorator(PublicAbstractBase order) : base(order) { }
        public override void PrintOrderItems()
        {
            Console.WriteLine("Shipping Costs May Apply");
            base.PrintOrderItems();
            Console.WriteLine("Grand Total with Shipping {0:C}", GetTotalCost());
            Console.WriteLine();
        }
        public override double GetTotalCost()
        {
            return base.GetTotalCost() + 4.00;
        }
    }
}
