using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class CustomDecorator
    {
        public int number { get; set; }
        public string word { get; set; }

        public CustomDecorator(int number, string word)
        {
            this.number = number;
            this.word = word;
        }
    }
}
