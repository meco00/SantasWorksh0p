namespace SantasWorkshop.Entities
{
    using SantasWorkshop.Command;
    using SantasWorkshop.Observer;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dwarf :IObserver
    {
        private string name;

        public Dwarf(string name)
        {
            this.name = name; 
        }

        public void update(GetToyForSantaCommand command, RemoteController remoteController)
        {
            remoteController.setCommand(command);
            remoteController.pressButton();
        }
    }
}
