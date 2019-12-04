using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Visitor
{
    public interface IVisitor
    {
        void Visit(BombPicture picture);
        void Visit(PlayerPicture picture);
        void Visit(ExplosionPicture picture);
    }
}
