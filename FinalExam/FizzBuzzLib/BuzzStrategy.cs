﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class BuzzStrategy : ReadResultStrategy
    {
        public override void ResultInterface()
        {
            Console.WriteLine("Buzz");
        }
    }
}