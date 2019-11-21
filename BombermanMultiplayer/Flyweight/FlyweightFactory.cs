using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer
{
    class FlyweightFactory
    {
       private Dictionary<Player.MovementDirection, CheckCollision> _strategies = new Dictionary<Player.MovementDirection, CheckCollision>();

        public CheckCollision GetStrategy(Player.MovementDirection direction)
        {
            // Uses "lazy initialization"
            
            if (_strategies.ContainsKey(direction))
            {
                return _strategies[direction];
            }
            else
            {
                CheckCollision strategy = null;
                switch (direction)
                {
                    case Player.MovementDirection.UP:
                        strategy = new CheckCollision(new CheckUpStrategy());
                        break;
                    case Player.MovementDirection.DOWN:
                        strategy = new CheckCollision(new CheckDownStrategy());
                        break;
                    case Player.MovementDirection.LEFT:
                        strategy = new CheckCollision(new CheckLeftStrategy());
                        break;
                    case Player.MovementDirection.RIGHT:
                        strategy = new CheckCollision(new CheckRightStrategy());
                        break;
                }
                _strategies.Add(direction, strategy);
                return strategy;
            }
        }
    }
}
