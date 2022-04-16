namespace SantasWorkshop.Command
{
    using SantasWorkshop.Entities;
    using SantasWorkshop.Observer;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class UnregisterDwarfCommand : Command
    {
        private SantaObserver santaObserver;
        private Dwarf dwarf;

        public UnregisterDwarfCommand(SantaObserver santaObserver, Dwarf dwarf)
        {
            this.santaObserver = santaObserver;
            this.dwarf = dwarf;
        }


        public override void Execute()
        {
            this.santaObserver.Unregister(this.dwarf);
        }
    }
}
