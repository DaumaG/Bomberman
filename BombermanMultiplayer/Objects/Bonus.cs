using BombermanMultiplayer.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects
{
    [Serializable]
    public class Bonus : GameObject
    {

        public BonusType Type = BonusType.None;


        public Bonus(int x, int y, int frameNumber, int frameWidth, int frameHeight, BonusType type) 
            : base(x, y, frameNumber, frameWidth, frameHeight)
        {
            this.Type = type;

        }

        public void Send(string message, GameObject receiver)
        {
            Console.WriteLine("Bonus sends message: " + message);
            mediator.SendMessage(this, receiver, message);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Bonus gets message: " + message);
        }

        public void CheckCasePosition(int TileWidth, int TileHeight)
        {
            this.CasePosition[0] = this.Source.Y / TileWidth; //Ligne
            this.CasePosition[1] = this.Source.X / TileWidth; //Colonne
        }

        #region Template pattern

        public sealed override bool IsImageNeeded()
        {
            return true;
        }

        public sealed override bool IsRectangleNeeded()
        {
            return true;
        }

        #endregion
    }

    public enum BonusType
    {
        None,
        PowerBomb,
        SpeedBoost,
        Desamorce,
        Armor
    }
}
