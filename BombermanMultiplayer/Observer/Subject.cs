/**
 * @(#) Subject.cs
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BombermanMultiplayer.Objects;

namespace Observer
{

    public abstract class Subject
	{
		private List<IObserver> observers = new List<IObserver>();


        public void attach(IObserver player)
        {
            observers.Add(player);
            player.setGameArea(this);
        }
        	
		public void detach( IObserver player )
		{
			this.observers.Remove(player);
		}
		
		public void notifyObservers( string message )
		{
            foreach (IObserver observers in this.observers) {
                observers.update(message); }
		}
		
        public void playersSpawned(IObserver player)
        {
            string message = player.getName() + " has Spawned";
            Debug.WriteLine("+- Observer Action -+");
            this.notifyObservers(message);
        }
	}
	
}
