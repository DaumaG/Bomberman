

using BombermanMultiplayer.Objects;
/**
* @(#) Damage.cs
*/
namespace Decorator
{
    public class Damage : PlayerDecorator
    {
        public Damage(PlayerComponent component) : base(component)
        {
        }

        public override BonusType customDraw1(BonusType innerResult)
        {
            return innerResult;
        }
        public override short customDraw2(short innerResult)
        {
            return innerResult;
        }
    }

}
