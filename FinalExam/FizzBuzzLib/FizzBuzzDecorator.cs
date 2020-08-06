﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzBuzzDecorator : OutputDecorator
    {
        public override void ProduceOutput()
        {
            base.ProduceOutput();
            Console.WriteLine("FizzBuzz");
        }
    }
}