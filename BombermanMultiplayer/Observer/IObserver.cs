/**
 * @(#) IObserver.cs
 */

namespace Observer
{
	public interface IObserver
	{
        void update(string message);

        string getName();

        Observer.Subject getGameArea();

        void setGameArea(Observer.Subject gameArea);
    }
	
}
