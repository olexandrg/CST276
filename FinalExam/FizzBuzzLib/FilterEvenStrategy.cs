using FizzBuzzLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class FilterEvenStrategy : UserOptionsStrategy, IFilterIntegers
    {
        List<string> list = new List<string>();
        CreateCustomListStrategy custom_list;


        public void CreateList()
        {
            for (int i = custom_list.start; i <= custom_list.stop; ++i)
                if (i % 2 != 0)
                    list.Add(custom_list.CheckList(i));
        }

        public override List<string> GetNewList()
        {
            return list;
        }

        public override void ProcessUserOption()
        {
            CreateCustomListStrategy strategy = new CreateCustomListStrategy();
            strategy.SetCustomRange();
            strategy.AddToCustomList();
            custom_list = strategy;
            CreateList();

        }
    }
}