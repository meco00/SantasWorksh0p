namespace SantasWorkshop.Observer
{
    using SantasWorkshop.Command;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SantaObserver : IObservable
    {
        private List<IObserver> observers;
        private RemoteController remote;

        public SantaObserver(RemoteController remote)
        {
            this.observers = new List<IObserver>();
            this.remote = remote;

        }
   

        public void NotifyObservers(GetToyForSantaCommand command)
        {
            foreach (var observer in this.observers)
            {
                observer.update(command,remote);
            }
        }

        public void Register(IObserver observer)
        {
            this.observers.Add(observer);

        }

        public void Unregister(IObserver observer)
        {
            var currentObserverIndex = this.observers.IndexOf(observer);
            if(currentObserverIndex == -1)
            {
                return;
            }

            this.observers.RemoveAt(currentObserverIndex);
        }
    }
}
