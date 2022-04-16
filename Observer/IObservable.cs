namespace SantasWorkshop.Observer
{
    using SantasWorkshop.Command;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public interface IObservable
    {
        void Register(IObserver observer);

        void Unregister(IObserver observer);

        void NotifyObservers(GetToyForSantaCommand command);

    }
}
