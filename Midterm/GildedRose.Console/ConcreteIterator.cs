using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        // Constructor
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        public override object First()
        {
            return aggregate[0];
        }

        // Gets next iteration
        public override object Next()
        {
            object ret = null;
            if (current < aggregate.Count - 1)
                ret = aggregate[++current];

            return ret;
        }

        // Checks if iterations are completed

        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }
}
