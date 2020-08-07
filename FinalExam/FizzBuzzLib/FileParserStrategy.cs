using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FinalExam
{
    public class FileParserStrategy : UserOptionsStrategy
    {
        private List<string> list;

        public FileParserStrategy(List<string> list)
        {
            this.list = list;
        }
        public override void ProcessUserOption()
        {
            Console.WriteLine("Please check the FinalExam directory for the output.txt file\n");
            Parser();
        }

        public void Parser()
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"..\..\output.txt"))
            {
                foreach (string line in list)
                    file.WriteLine(line);
            }
        }

        public override List<string> GetNewList()
        {
            return list;
        }
    }
}
