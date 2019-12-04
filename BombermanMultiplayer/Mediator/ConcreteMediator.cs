using BombermanMultiplayer.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Mediator
{
    public class ConcreteMediator : IMediator
    {
        private Player _player;
        private Bonus _bonus;
        private Bomb _bomb;

        public Player PlayerMessages
        {
            set { _player = value; }
        }

        public Bonus BonusMessages
        {
            set { _bonus = value; }
        }

        public Bomb BombMessages
        {
            set { _bomb = value; }
        }

        public void SendMessage(GameObject sender, GameObject receiver, string message)
        {
            if (sender == _player)
            {
                if (receiver == _bomb)
                {
                    _bomb.Notify(message);

                } else
                {
                    _bonus.Notify(message);
                }
            }
            else
            {
                _player.Notify(message);
            }
        }
    }
}
