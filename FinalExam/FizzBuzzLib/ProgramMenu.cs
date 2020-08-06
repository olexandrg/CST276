using FinalExam;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class ProgramMenu 
    {
        FizzBuzz program;

        private int start_ = 1;
        private int stop_ = 100;

        public List<CustomDecorator> custom_items = new List<CustomDecorator>();
        public List<string> list = new List<string>();

        public object Current => throw new NotImplementedException();

        public void PrintMenu()
        {
            bool selection = true;

            while (selection)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("[1] Print Standard FizzBuzz");
                Console.WriteLine("[2] Create Custom output");
                Console.WriteLine("[3] Print Custom output");
                Console.WriteLine("[4] Export Custom output to file");
                Console.WriteLine("[5] Reverse list order");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        program = new FizzBuzz(new StandardFizzBuzzStrategy());
                        program.InputHandler();
                        break;
                    case "2":
                        SetCustomRange();
                        AddToCustomList();
                        break;
                    case "3":
                        PrintListInAscendingOrder();
                        break;
                    case "4":
                        program = new FizzBuzz(new FileParserStrategy(list));
                        program.InputHandler();
                        break;
                    case "5":
                        ReverseList();
                        break;
                    default:
                        selection = false;
                        break;
                }
            }
        }

        public void SetCustomRange()
        {
            Console.WriteLine("Enter start number:");

            this.start_ = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter stop number:");

            this.stop_ = Convert.ToInt32(Console.ReadLine());
        }
        private void AddToCustomList()
        {
            bool selection = true;
            int number;
            string word;
            string user_select;

            while (selection)
            {
                try
                {
                    Console.WriteLine("Enter custom number:");
                    number = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter custom word:");
                    word = Console.ReadLine();

                    custom_items.Add(new CustomDecorator(number, word));

                    Console.WriteLine("Add another custom item?:\n" +
                        "[Any key] Add another \n" +
                        "[2] Exit and create custom list\n");
                    user_select = Console.ReadLine();

                    if (user_select == "2") selection = false;
                }
                catch (Exception ex)
                {
                    Console.Write("Please enter a valid number." + ex);
                }
            }

            CreateList();

        }
        public void CreateList()
        {
            for (int i = start_; i <= stop_; ++i)
                list.Add(CheckList(i));
        }
        private string CheckList(int i)
        {
            StringBuilder sb = new StringBuilder();

            foreach(CustomDecorator item in custom_items)
                if (i % item.number == 0) 
                    sb.Append(item.word);

            if (sb.Length == 0)
                return (Convert.ToString(i));

            string names = sb.ToString();

            return names;
        }

        public void PrintListInAscendingOrder()
        {
            foreach (string item in list)
                Console.WriteLine(item);
        }

        public void ReverseList()
        {
            list.Reverse();
        }

    }
}
