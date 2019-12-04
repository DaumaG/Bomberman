using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer
{
    class Memento
    {
        private int _bombIndex;
        private int[] _bombPosition = new int[2];

        // Constructor

        public Memento(int bombIndex, int[] bombPosition)
        {
            this._bombIndex = bombIndex;
            this._bombPosition = bombPosition;
        }

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
    }
}
