using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Iterator
{
    public class ConcreteIterator : IIterator
    {
        private ConcreteContainer container;
        private int current = 0;

        public ConcreteIterator(ConcreteContainer container)
        {
            this.container = container;
        }

        public object First()
        {
            return container[0];
        }

        public object Next()
        {
            object ret = null;
            if (current < container.Count - 1)
            {
                ret = container[++current];
            }

            return ret;
        }

        public object CurrentItem()
        {
            return container[current];
        }

        public bool IsDone()
        {
            return current >= container.Count;
        }
    }
}
