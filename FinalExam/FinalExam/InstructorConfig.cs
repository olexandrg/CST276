using System;
using System.Collections.Generic;
using System.IO;
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
            // Open config file and store raw data
            FileReader fileReader = new FileReader(@"..\..\config.txt");
            fileReader.Parser();

            // Store data on a member list
            list = fileReader.GetList();
            custom_items = fileReader.GetCustomList();

            // Check Filtering
            if (fileReader.filtering == 1)
            {
                FilterOddStrategy filterOddStrategy = new FilterOddStrategy(list);
                list = filterOddStrategy.GetNewList();
            }
            else if (fileReader.filtering == 2)
            {
                FilterEvenStrategy filterOddStrategy = new FilterEvenStrategy(list);
                list = filterOddStrategy.GetNewList();
            }

            // Check order of printing
            if (fileReader.printingorder == 1) ReverseList();

            // Create a new list
            CreateCustomListStrategy strategy = new CreateCustomListStrategy(fileReader.start, fileReader.stop, list, custom_items);
            strategy.CreateList();
            list = strategy.GetNewList();

            // Check Output Type
            if (fileReader.output == 1)
            {
                FileParserStrategy fileParser = new FileParserStrategy(list);
                fileParser.ProcessUserOption();
            }
            else
                PrintList();
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
