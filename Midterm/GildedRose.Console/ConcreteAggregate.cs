using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class ConcreteAggregate : Aggregate
    {
        private ArrayList days = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return days.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return days[index]; }
            set { days.Insert(index, value); }
        }


       
    }
}
