using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzDecorator : OutputDecorator
    {
        public override void ProduceOutput()
        {
            base.ProduceOutput();
            Console.Write("Fizz");
        }
    }
}
