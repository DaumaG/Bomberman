

using BombermanMultiplayer.Objects;
/**
* @(#) Shied.cs
*/
namespace Decorator
{
	public class Shied : PlayerDecorator
	{
        public Shied(PlayerComponent component) : base(component)
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
