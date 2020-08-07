using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLib;

namespace FinalExam
{
    public class InstructorConfig : UserOptionsStrategy
    {
        private List<string> list = new List<string>();
        List<CustomDecorator> custom_items = new List<CustomDecorator>();

        public override List<string> GetNewList()
        {
            return list;
        }

        public override void ProcessUserOption()
        {
            using (System.IO.StreamReader file =
                new System.IO.StreamReader(@"..\..\config.txt"))
            {
                string line;
                int output;
                int start;
                int stop;
                int filtering;
                int printingorder;

                // 0 output to console or 1 to file
                output = Convert.ToInt32(file.ReadLine());

                // start number
                start = Convert.ToInt32(file.ReadLine());

                // stop number
                stop = Convert.ToInt32(file.ReadLine());

                // 0 for no filtering, 1 for odd, 2 for even
                filtering = Convert.ToInt32(file.ReadLine());

                // Order of printing 0 for default, 1 for reverse
                printingorder = Convert.ToInt32(file.ReadLine());

                // skip a line
                line = file.ReadLine();

                // read custom multiples and names
                while ((line = file.ReadLine()) != "###")
                {
                    string[] strsplit = line.Split(',');
                    int multiple = Convert.ToInt32(strsplit[0]);
                    string word = strsplit[1];

                    custom_items.Add(new CustomDecorator(multiple, word));

                }

                // read the rest of the numbers
                while ((line = file.ReadLine()) != null)
                {
                    list.Add(line);
                }


                // Check Filtering
                if (filtering == 1)
                {
                    FilterOddStrategy filterOddStrategy = new FilterOddStrategy(list);
                    list = filterOddStrategy.GetNewList();
                }
                else if (filtering == 2)
                {
                    FilterEvenStrategy filterOddStrategy = new FilterEvenStrategy(list);
                    list = filterOddStrategy.GetNewList();
                }

                // Check order of printing
                if (printingorder == 1) ReverseList();

                // Create a new list
                CreateCustomListStrategy strategy = new CreateCustomListStrategy(start, stop, list, custom_items);
                strategy.CreateList();
                list = strategy.GetNewList();

                // Check Output Type
                if (output == 1)
                {
                    FileParserStrategy fileParser = new FileParserStrategy(list);
                    fileParser.ProcessUserOption();
                }
                else
                    PrintList();
            }
        }

        public void PrintList()
        {
            foreach (string item in list)
                Console.WriteLine(item);
        }

        public void ReverseList()
        {
            list.Reverse();
        }

        public void StoreList(List<string> list)
        {
            this.list = list;
        }
    }
}
