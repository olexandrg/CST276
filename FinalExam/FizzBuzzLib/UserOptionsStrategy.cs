using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public abstract class UserOptionsStrategy
    {
        public abstract void ProcessUserOption();

        public abstract List<string> GetNewList();

    }
}
