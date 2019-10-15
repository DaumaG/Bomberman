using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer
{
    public class WorldFactory : AbstractFactory
    {
        public override GameObject Create()
        {
            return new World();
        }

        public override GameObject Create(int width, int height, int totalFrameTile)
        {
            return new World(width, height, 48, 48, totalFrameTile);
        }

        public GameObject Create(int width, int height, Tile[,] mapGrid)
        {
            return new World(width, height, mapGrid);
        }
    }
}
