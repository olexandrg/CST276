using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzDecorator : OutputDecorator
    {
        public override CustomDecorator ProduceOutput()
        {
            base.ProduceOutput();
            CustomDecorator fizz = new CustomDecorator(3, "Fizz");

            return fizz;
            
        }

        
    }
}
