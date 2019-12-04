using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer
{
    [Serializable]
    class CareTaker
    {
        //list of states saved
        private static List<Memento> mementoList = new List<Memento>();

        // Property

        public Memento Memento
        {
            set { mementoList.Add(value); }
            get { return mementoList[mementoList.Count - 1]; }
        }
    }
}
