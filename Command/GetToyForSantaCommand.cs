namespace SantasWorkshop.Command
{
    using SantasWorkshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GetToyForSantaCommand : Command
    {
        private Santa santa;
        private Workshop workshop;
        private string toyType;

        public GetToyForSantaCommand(Santa santa,Workshop workshop,string toyType)
        {
            this.santa = santa;
            this.workshop = workshop;
            this.toyType = toyType;
                
        }

        public override void Execute()
        {
            var toy = workshop.GetToy(toyType);

            if (toy == null)
            {
                Console.WriteLine($"There is no {toyType} left");
                return;
            }

            santa.AddToy(toy);
        }
    }
}
