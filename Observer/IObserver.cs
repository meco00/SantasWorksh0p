namespace SantasWorkshop.Observer
{
    using SantasWorkshop.Command;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public interface IObserver
    {
        void update(GetToyForSantaCommand command,RemoteController remoteController);

    }
}
