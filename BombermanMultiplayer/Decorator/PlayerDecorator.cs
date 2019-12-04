

using BombermanMultiplayer.Objects;
/**
* @(#) PlayerDecorator.cs
*/
namespace Decorator
{
	public abstract class PlayerDecorator : PlayerComponent
	{
		private PlayerComponent innerElement;
		

		public BonusType PowerBomb(  )
		{
            return customDraw1(this.innerElement.PowerBomb());
        }
        public short BonusTypeTimer()
        {
            return customDraw2(this.innerElement.BonusTypeTimer());
        }
		
		public PlayerDecorator(  PlayerComponent component)
		{
            this.innerElement = component;
        }

        public abstract BonusType customDraw1(BonusType innerResult);
        public abstract short customDraw2(short innerResult);

    }
	
}
