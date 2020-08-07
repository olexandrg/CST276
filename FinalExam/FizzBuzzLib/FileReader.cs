using FinalExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FileReader
    {
        private List<string> list = new List<string>();
        private List<CustomDecorator> custom_items = new List<CustomDecorator>();
        string filename;

        public int output { get; set; }
        public int start { get; set; }
        public int stop { get; set; }
        public int filtering { get; set; }
        public int printingorder { get; set; }

        public FileReader(string filename)
        {
            this.filename = filename;
        }

        public List<string> GetList()
        {
            return list;
        }

        public List<CustomDecorator> GetCustomList()
        {
            return custom_items;
        }
        public void Parser()
        {
            using (System.IO.StreamReader file =
                new System.IO.StreamReader(filename))
            {
                string line;

                // 0 output to console or 1 to file
                this.output = Convert.ToInt32(file.ReadLine());

                // start number
                this.start = Convert.ToInt32(file.ReadLine());

                // stop number
                this.stop = Convert.ToInt32(file.ReadLine());

                // 0 for no filtering, 1 for odd, 2 for even
                this.filtering = Convert.ToInt32(file.ReadLine());

                // Order of printing 0 for default, 1 for reverse
                this.printingorder = Convert.ToInt32(file.ReadLine());

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
            }
        }
    }
}
