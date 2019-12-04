using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Iterator
{
    [Serializable]
    public class ConcreteContainer : IContainer
    {
        private ArrayList _items = new ArrayList();

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }

        public void Add(object o)
        {
            _items.Add(o);
        }
        public void Remove(object o)
        {
            _items.Remove(o);
        }
    }
}
