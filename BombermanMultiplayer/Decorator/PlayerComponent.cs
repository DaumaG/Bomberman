

using BombermanMultiplayer.Objects;
/**
* @(#) PlayerComponent.cs
*/
namespace Decorator
{
	public interface PlayerComponent
	{
		BonusType PowerBomb(  );
        short BonusTypeTimer();
		
	}
	
}
