/**
 * @(#) Subject.cs
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BombermanMultiplayer.Iterator;
using BombermanMultiplayer.Objects;

namespace Observer
{

    public abstract class Subject
	{
        private ConcreteContainer observers = new ConcreteContainer();

        public void attach(IObserver player)
        {
            observers.Add(player);
            player.setGameArea(this);
        }
        	
		public void detach( IObserver player )
		{
            observers.Remove(player);
		}
		
		public void notifyObservers( string message )
		{
            ConcreteIterator observersIterator = (ConcreteIterator)observers.CreateIterator();
            IObserver item = (IObserver)observersIterator.First();
            while (item != null)
            {
                item.update(message);
                item = (IObserver)observersIterator.Next();
            }
		}
		
        public void playersSpawned(IObserver player)
        {
            string message = player.getName() + "s have spawned";
            Debug.WriteLine("+- Observer Action -+");
            this.notifyObservers(message);
        }
	}
	
}
