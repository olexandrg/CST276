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

        public StandardFizzBuzzStrategy()
        {
            for (int i = 1; i <= 100; ++i)
                list.Add(i.ToString());
        }

        public override void ProcessUserOption()
        {
            FizzDecorator fizz = new FizzDecorator();
            BuzzDecorator buzz = new BuzzDecorator();

            List<CustomDecorator> custom_items = new List<CustomDecorator>();
            custom_items.Add(fizz.ProduceOutput());
            custom_items.Add(buzz.ProduceOutput());

            CreateCustomListStrategy standardFizzBuzz = new CreateCustomListStrategy(0,0,list ,custom_items);

            standardFizzBuzz.CreateList();

            list = standardFizzBuzz.GetNewList();
            PrintList();
        }

        public void PrintList()
        {
            foreach (string item in list)
                Console.WriteLine(item);
        }
    }
}
