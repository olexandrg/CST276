using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class BuzzDecorator : OutputDecorator
    {
        public override CustomDecorator ProduceOutput()
        {
            base.ProduceOutput();

            CustomDecorator buzz = new CustomDecorator(5, "Buzz");

            return buzz;
        }
    }
}
