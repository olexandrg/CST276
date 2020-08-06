using FinalExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class CreateCustomListStrategy : UserOptionsStrategy
    {
        private List<string> list = new List<string>();
        public List<CustomDecorator> custom_items = new List<CustomDecorator>();

        private int start;
        private int stop;

        // default constructor
        public CreateCustomListStrategy()
        {

        }

        // pass custom start / stop for testing
        public CreateCustomListStrategy(int start, int stop)
        {
            this.start = start;
            this.stop = stop;
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

        public void SetCustomRange()
        {
            Console.WriteLine("Enter start number:");

            this.start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter stop number:");

            this.stop = Convert.ToInt32(Console.ReadLine());
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
        }
        public void CreateList()
        {
            for (int i = start; i <= stop; ++i)
                list.Add(CheckList(i));
        }
        private string CheckList(int i)
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

    }
}
