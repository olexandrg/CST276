using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class RomanNumeralsStrategy : UserOptionsStrategy
    {
        private List<string> list = new List<string>();

        public override List<string> GetNewList()
        {
            return list;
        }

        public override void ProcessUserOption()
        {
            throw new NotImplementedException();
        }
    }
}
