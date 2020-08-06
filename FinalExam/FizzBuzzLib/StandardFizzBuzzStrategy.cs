using FinalExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class StandardFizzBuzzStrategy : UserOptionsStrategy
    {
        private List<string> list = new List<string>();

        public override List<string> GetNewList()
        {
            return list;
        }

        public override void ProcessUserOption()
        {
            FizzDecorator fizz = new FizzDecorator();
            BuzzDecorator buzz = new BuzzDecorator();

            CreateCustomListStrategy menu = new CreateCustomListStrategy(1,100);
            menu.custom_items.Add(fizz.ProduceOutput());
            menu.custom_items.Add(buzz.ProduceOutput());

            menu.CreateList();

            list = menu.GetNewList();
        }

     
    }
}
