using FinalExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FileReaderStrategy : UserOptionsStrategy
    {
        private List<string> list = new List<string>();
        string filename = "config.txt";

        public override List<string> GetNewList()
        {
            return list;
        }

        public override void ProcessUserOption()
        {
            Console.WriteLine("Enter the filename to process");
            this.filename = Console.ReadLine();
            Parser(filename);
        }

        public void Parser(string filename)
        {

            using (System.IO.StreamReader file =
            new System.IO.StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    int num = Convert.ToInt32(line);
                    list.Add(num.ToString());
                }
            }
        }
    }
}
