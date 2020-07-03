using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDll
{
    public interface IOrderDecorator
    {
        double AddExpressShipping();
        double GetTotalCost();
    }
}
