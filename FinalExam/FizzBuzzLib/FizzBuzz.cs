﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class FizzBuzz : IPrintIterator
    {
        private ReadResultStrategy strategy;

        public FizzBuzz()
        {

        }
        public FizzBuzz(ReadResultStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void InputHandler()
        {
            strategy.ResultInterface();
        }

        public void InputHandler(int i)
        {
            Console.WriteLine(i);
        }
    }
}
