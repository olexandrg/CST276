using FizzBuzzLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class FilterOddStrategy : UserOptionsStrategy
    {
        List<string> list = new List<string>();

        public void CreateList()
        {
            List<string> new_list = new List<string>();

            foreach (string item in list)
                if (Convert.ToInt32(item) % 2 == 0)
                    new_list.Add(item);

            list = new_list;
        }

        public FilterOddStrategy()
        {

        }
        public FilterOddStrategy(List<string> list)
        {
            this.list = list;

        }

        public override List<string> GetNewList()
        {
            return list;
        }

        public override void ProcessUserOption()
        {
            CreateList();
        }
    }
}