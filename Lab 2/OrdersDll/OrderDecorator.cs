using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDll
{
    public class OrderDecorator : PublicAbstractBase
    {
        protected PublicAbstractBase order;

        public OrderDecorator(PublicAbstractBase order)
        {
            this.order = order;
        }

        public override void AddItem(string productCode, int quantity, double cost, double weight)
        {
           order.AddItem(productCode, quantity, cost, weight);
        }

        public override void PrintOrderItems()
        {
            order.PrintOrderItems();
        }

        public override double GetTotalCost()
        {
            return order.GetTotalCost();
        }
    }

    public class ExpressDeliveryOrderDecorator : OrderDecorator
    {
        public ExpressDeliveryOrderDecorator(PublicAbstractBase order) : base(order) {}
        public override void PrintOrderItems()
        {
            Console.WriteLine("Shipping Costs May Apply");
            Console.WriteLine();
            base.PrintOrderItems();
            Console.WriteLine("Grand Total with Shipping {0:C}", GetTotalCost());
        }
        public override double GetTotalCost()
        {
            return base.GetTotalCost() + 4.00;
        }
    }
}
