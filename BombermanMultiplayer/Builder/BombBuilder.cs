using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Builder
{
    public class BombBuilder
    {
        public int detonationTime;
        public int bombPower;

        private int caseLigne;
        private int caseCol;
        private int totalFrames;
        private int frameWidth;
        private int frameHeight;
        private int TileWidth;
        private int TileHeight;
        private short proprietary;

        private bool bombAlreadyCreated = false;

        private Bomb originalBomb;

        /**
         * Constructor
         */
        public BombBuilder()
        {
        }

        public BombBuilder AddInfo(int caseLigne, int caseCol, int totalFrames, int frameWidth, int frameHeight, int TileWidth, int TileHeight, short proprietary)
        {
            this.caseLigne = caseLigne;
            this.caseCol = caseCol;
            this.totalFrames = totalFrames;
            this.frameWidth = frameWidth;
            this.frameHeight = frameHeight;
            this.TileWidth = TileWidth;
            this.TileHeight = TileHeight;
            this.proprietary = proprietary;
            return this;
        }

        public BombBuilder AddDetonationTime(BombDetonation detonationTime)
        {
            this.detonationTime = detonationTime.toInt();
            return this;
        }
        public BombBuilder AddPower(BombPower bombPower)
        {
            this.bombPower = bombPower.toInt();
            return this;
        }

        public Bomb Build()
        {
            if (!bombAlreadyCreated)
            {
                Console.WriteLine("Bomb created.");
                bombAlreadyCreated = true;
                originalBomb = new Bomb(this, caseLigne, caseCol, totalFrames, frameWidth, frameHeight, TileWidth, TileHeight, proprietary);
                return originalBomb;
            }
            else
            {
                Console.WriteLine("Bomb copied.");
                Bomb copiedBomb = originalBomb.Clone();
                copiedBomb.SetPosition(caseLigne, caseCol);
                copiedBomb.SetProprietary(this.proprietary);
                copiedBomb.SetDetonationTime(this.detonationTime);
                return copiedBomb;
            }
        }
    }
}
