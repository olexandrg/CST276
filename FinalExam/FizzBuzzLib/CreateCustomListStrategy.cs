using FinalExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class CreateCustomListStrategy : UserOptionsStrategy, IFilterIntegers
    {
        public List<string> list = new List<string>();
        public List<CustomDecorator> custom_items = new List<CustomDecorator>();

        public int start { get; set; }
        public int stop { get; set; }

        // default constructor
        public CreateCustomListStrategy()
        {

        }

        // pass custom start / stop for testing
        public CreateCustomListStrategy(int stop = 0, int start = 0)
        {
            this.start = start;
            this.stop = stop;
        }

        // pass custom start, stop, and pre-made list
        public CreateCustomListStrategy(int start, int stop, List<string> list, List<CustomDecorator> custom_items)
        {
            this.start = start;
            this.stop = stop;
            this.list = list;
            this.custom_items = custom_items;
        }

        public void SetCustomItems(List<CustomDecorator> custom_items)
        {
            this.custom_items = custom_items;
        }

        public override void ProcessUserOption()
        {
            SetCustomRange();
            AddToCustomList();
            CreateList();
        }

        public List<string> GetCustomList()
        {
            return list;
        }

        public void CreateList()
        {
            List<string> new_list = new List<string>();

            if (start != 0)
                list.RemoveRange(0, start);

            foreach (string item in list)
                new_list.Add(CheckList(Convert.ToInt32(item)));

            list = new_list;
        }

        public string CheckList(int i)
        {
            StringBuilder sb = new StringBuilder();

            foreach (CustomDecorator item in custom_items)
                if (i % item.number == 0)
                    sb.Append(item.word);

            if (sb.Length == 0)
                return (Convert.ToString(i));

            string names = sb.ToString();

            return names;
        }
        public override List<string> GetNewList()
        {
            return list;
        }
        public void SetCustomRange()
        {
            Console.WriteLine("Enter start number:");

            this.start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter stop number:");

            this.stop = Convert.ToInt32(Console.ReadLine());
        }
        public void AddToCustomList()
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
        }
    }
}
