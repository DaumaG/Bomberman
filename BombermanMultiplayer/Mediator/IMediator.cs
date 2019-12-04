using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer
{
    public interface IMediator
    {
        void SendMessage(GameObject sender, GameObject receiver, String message);
    }
}
