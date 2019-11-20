using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;
using System.Diagnostics;
using BombermanMultiplayer.Builder;

namespace BombermanMultiplayer
{
    [Serializable]
    public class Bomb : GameObject, IDisposable
    {
        public bool Explosing = false;

        private int detonationTime;
        private int bombPower;

        //Who drops the bomb, player 1 = 1, player 2 = 2
        public short Proprietary;

        public int TileHeight;
        public int TileWidth;

        public int DetonationTime
        {
            get
            {
                return detonationTime;
            }

            set
            {
                if(detonationTime > 0)
                detonationTime = value;
            }
        }
        
        public Bomb()
        {
        }

        public Bomb(BombBuilder builder, int caseLigne, int caseCol, int totalFrames, int frameWidth, int frameHeight, int TileWidth, int TileHeight, short proprietary)
            : base(caseCol * TileWidth, caseLigne * TileHeight, totalFrames, frameWidth, frameHeight)
        {
            CasePosition = new int[2] { caseLigne, caseCol };
            this.TileHeight = TileHeight;
            this.TileWidth = TileWidth;
            //Charge the sprite
            this.LoadSprite(Properties.Resources.Bombe);
            //Define the proprietary player (who drops this bomb)
            this.Proprietary = proprietary;
            this._frameTime = DetonationTime / 8;
            this.bombPower = builder.bombPower;
            this.detonationTime = builder.detonationTime;
        }

        public Bomb Clone()
        {
            this.Explosing = false;
            return (Bomb)this.MemberwiseClone();
        }

        public void SetPosition(int caseLigne, int caseCol)
        {
            CasePosition = new int[2] { caseLigne, caseCol };
            this.ChangeLocation(caseCol * this.TileWidth, caseLigne * this.TileHeight);
            this.LoadSprite(Properties.Resources.Bombe);
        }

        public void SetProprietary(short proprietary)
        {
            this.Proprietary = proprietary;
        }

        public void SetDetonationTime (int detonationTime)
        {
            this.detonationTime = detonationTime;
        }

        public void TimingExplosion(int elsapedTime)
        {
            if (detonationTime <= 0)
            {
                this.Explosing = true;
            }
            detonationTime -= elsapedTime;
        }

        public void Explosion(Tile[,] MapGrid, Player player1, Player player2)
        {
            int variablePosition = 0;

            bool PropagationUP, PropagationDOWN, PropagationLEFT, PropagationRIGHT;
            PropagationUP = PropagationDOWN = PropagationLEFT = PropagationRIGHT = true;


            //Give back a bomb to the proprietary 
            if (Proprietary == 1)
            {
                player1.BombNumb++;

                if (player1.BonusSlot[0] == Objects.BonusType.PowerBomb || player1.BonusSlot[1] == Objects.BonusType.PowerBomb)
                {
                    this.bombPower++;
                }
            }
            else if (Proprietary == 2)
            {
                player2.BombNumb++;

                if (player2.BonusSlot[0] == Objects.BonusType.PowerBomb || player2.BonusSlot[1] == Objects.BonusType.PowerBomb)
                {
                    this.bombPower++;
                }
            }

            //Check if player
            if (this.CasePosition == player1.CasePosition
                && player1.BonusSlot[0] != Objects.BonusType.Armor && player1.BonusSlot[1] != Objects.BonusType.Armor)
            {
                player1.Dead = true;
                player1.LoadSprite(Properties.Resources.Blood);
            }
            if (this.CasePosition == player2.CasePosition
                && player2.BonusSlot[0] != Objects.BonusType.Armor && player2.BonusSlot[1] != Objects.BonusType.Armor)
            {
                player2.Dead = true;
                player2.LoadSprite(Properties.Resources.Blood);
            }


            for (int i = 0; i < this.bombPower; i++)
            {

                //UP
                //If there's nothing undestroyable obstruing the path of the explosion
                if (PropagationUP)
                {

                    //If not out of bounds
                    if ((variablePosition = this.CasePosition[0] - i) <= MapGrid.GetLength(0) - 1)
                    {
                        //if destroyable block
                        if (MapGrid[variablePosition, this.CasePosition[1]].Destroyable == true)
                        {
                            MapGrid[variablePosition, this.CasePosition[1]].Destroyable = false;
                            MapGrid[variablePosition, this.CasePosition[1]].Walkable = true;
                            MapGrid[variablePosition, this.CasePosition[1]].Fire = true;
                            MapGrid[variablePosition, this.CasePosition[1]].SpawnBonus();

                        }
                        else if (!MapGrid[variablePosition, this.CasePosition[1]].Destroyable && MapGrid[variablePosition, this.CasePosition[1]].Walkable)
                        {
                            //If free case 
                            MapGrid[variablePosition, this.CasePosition[1]].Fire = true;


                        }
                        else if (!MapGrid[variablePosition, this.CasePosition[1]].Destroyable && !MapGrid[variablePosition, this.CasePosition[1]].Walkable)
                        {
                            PropagationUP = false;
                        }
                    }

                }


                //DOWN
                if (PropagationDOWN)
                {

                    //If not out of bounds
                    if ((variablePosition = this.CasePosition[0] + i) >= 0)
                    {
                        //if destroyable block
                        if (MapGrid[variablePosition, this.CasePosition[1]].Destroyable == true)
                        {
                            MapGrid[variablePosition, this.CasePosition[1]].Destroyable = false;
                            MapGrid[variablePosition, this.CasePosition[1]].Walkable = true;
                            MapGrid[variablePosition, this.CasePosition[1]].Fire = true;
                            MapGrid[variablePosition, this.CasePosition[1]].SpawnBonus();

                        }
                        else if (!MapGrid[variablePosition, this.CasePosition[1]].Destroyable && MapGrid[variablePosition, this.CasePosition[1]].Walkable)
                        {
                            //If free case 
                            MapGrid[variablePosition, this.CasePosition[1]].Fire = true;


                        }
                        else if (!MapGrid[variablePosition, this.CasePosition[1]].Destroyable && !MapGrid[variablePosition, this.CasePosition[1]].Walkable)
                        {
                            PropagationDOWN = false;
                        }

                    }

                }

                //LEFT
                if (PropagationLEFT)
                {
                    //If not out of bounds
                    if ((variablePosition = this.CasePosition[1] - i) >= 0)
                    {
                        //if destroyable block
                        if (MapGrid[this.CasePosition[0], variablePosition].Destroyable == true)
                        {
                            MapGrid[this.CasePosition[0], variablePosition].Destroyable = false;
                            MapGrid[this.CasePosition[0], variablePosition].Walkable = true;
                            MapGrid[this.CasePosition[0], variablePosition].Fire = true;
                            MapGrid[this.CasePosition[0], variablePosition].SpawnBonus();

                        }
                        else if (MapGrid[this.CasePosition[0], variablePosition].Destroyable == false && MapGrid[this.CasePosition[0], variablePosition].Walkable)
                        {
                            //If free case 
                            MapGrid[this.CasePosition[0], variablePosition].Fire = true;


                        }
                        else if (!MapGrid[this.CasePosition[0], variablePosition].Destroyable && !MapGrid[this.CasePosition[0], variablePosition].Walkable)
                        {
                            PropagationLEFT = false;
                        }

                    }
                }
                //RIGHT
                if (PropagationRIGHT)
                {
                    //If not out of bounds
                    if ((variablePosition = this.CasePosition[1] + i) <= MapGrid.GetLength(1) - 1)
                    {
                        //if destroyable block
                        if (MapGrid[this.CasePosition[0], variablePosition].Destroyable == true)
                        {
                            MapGrid[this.CasePosition[0], variablePosition].Destroyable = false;
                            MapGrid[this.CasePosition[0], variablePosition].Walkable = true;
                            MapGrid[this.CasePosition[0], variablePosition].Fire = true;
                            MapGrid[this.CasePosition[0], variablePosition].SpawnBonus();
                        }
                        else if (MapGrid[this.CasePosition[0], variablePosition].Destroyable == false && MapGrid[this.CasePosition[0], variablePosition].Walkable)
                        {
                            //If free case 
                            MapGrid[this.CasePosition[0], variablePosition].Fire = true;


                        }
                        else if (!MapGrid[this.CasePosition[0], variablePosition].Destroyable && !MapGrid[this.CasePosition[0], variablePosition].Walkable)
                        {
                            PropagationRIGHT = false;
                        }

                    }
                }
            }

            MapGrid[this.CasePosition[0], this.CasePosition[1]].Occupied = false;
            MapGrid[this.CasePosition[0], this.CasePosition[1]].bomb = null;


            this.Dispose();

        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.Sprite = null;

                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
