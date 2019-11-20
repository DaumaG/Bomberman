using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Command
{
    using MovementDirection = BombermanMultiplayer.Player.MovementDirection;
    class MoveCommand : Command
    {
        private MovementDirection _direction;
        private byte _distance;
        private Player _player;
        //Constructor
        public MoveCommand(MovementDirection direction, byte distance, Player player)
        {
            this._direction = direction;
            this._distance = distance;
            this._player = player;
        }
        //Execute new command
        public override void Execute()
        {
            MoveOperation(_direction);
        }
        //Undo last command
        public override void Undo()
        {
            MoveOperation(InverseDirection(_direction));
        }

        private MovementDirection InverseDirection(MovementDirection direction)
        {
            MovementDirection inversedDirection = direction;
            switch (direction)
            {
                case MovementDirection.UP:
                    inversedDirection = MovementDirection.DOWN;
                    break;
                case MovementDirection.DOWN:
                    inversedDirection = MovementDirection.UP;
                    break;
                case MovementDirection.LEFT:
                    inversedDirection = MovementDirection.RIGHT;
                    break;
                case MovementDirection.RIGHT:
                    inversedDirection = MovementDirection.LEFT;
                    break;
            }

            return inversedDirection;
        }

        private void MoveOperation(MovementDirection direction)
        {
            switch (direction)
            {
                case MovementDirection.UP:
                    this._player.Bouger(0, -this._distance);
                    break;
                case MovementDirection.DOWN:
                    this._player.Bouger(0, this._distance);
                    break;
                case MovementDirection.LEFT:
                    this._player.Bouger(-this._distance, 0);
                    break;
                case MovementDirection.RIGHT:
                    this._player.Bouger(this._distance, 0);
                    break;
                default:
                    this._player.frameindex = 0;
                    break;
            }

        }
    }
}
