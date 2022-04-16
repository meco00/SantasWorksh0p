namespace SantasWorkshop.Command
{
    using SantasWorkshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class AddToyToWorkshopCommand : Command
    {
        private Workshop workshop;
        private Toy toy;

        public AddToyToWorkshopCommand(Workshop workshop,Toy toy)
        {
            this.workshop = workshop;
            this.toy = toy;
        }

        public override void Execute()
        {
            this.workshop.AddToy(this.toy);
        }
    }
}
