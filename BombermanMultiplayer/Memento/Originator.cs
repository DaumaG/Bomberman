using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer
{
    class Originator
    {
        private int _bombIndex;
        private int[] _bombPosition = new int[2];

        // Gets or sets BombIndex

        public int BombIndex
        {
            get { return _bombIndex; }
            set
            {
                _bombIndex = value;
            }
        }

        // Gets or sets BombPosition

        public int[] BombPosition
        {
            get { return _bombPosition; }
            set
            {
                _bombPosition = value;
            }
        }

        // Stores memento

        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(_bombIndex, _bombPosition);
        }

        // Restores memento

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            this.BombPosition = memento.BombPosition;
            this.BombIndex = memento.BombIndex;
        }
    }
}
