using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer
{
    public abstract class AbstractFactory
    {
        public abstract GameObject Create();
        public abstract GameObject Create(int a, int b, int c);
    }
}
