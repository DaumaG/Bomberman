using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer
{
    class FlyweightFactory
    {
       private Dictionary<Player.MovementDirection, ICheckCollisionStrategy> _strategies = new Dictionary<Player.MovementDirection, ICheckCollisionStrategy>();

        public ICheckCollisionStrategy GetStrategy(Player.MovementDirection direction)
        {
            // Uses "lazy initialization"

            ICheckCollisionStrategy strategy = null;
            if (_strategies.ContainsKey(direction))
            {
                strategy = _strategies[direction];
            }
            else
            {
                switch (direction)
                {
                    case Player.MovementDirection.UP:
                        strategy = new CheckUpStrategy();
                        break;
                    case Player.MovementDirection.DOWN:
                        strategy = new CheckDownStrategy();
                        break;
                    case Player.MovementDirection.LEFT:
                        strategy = new CheckLeftStrategy();
                        break;
                    case Player.MovementDirection.RIGHT:
                        strategy = new CheckRightStrategy();
                        break;
                }
                _strategies.Add(direction, strategy);
            }

            return strategy;
        }
    }
}
