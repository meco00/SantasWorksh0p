namespace SantasWorkshop.Factories
{
    using SantasWorkshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class DwarfFactory
    {
        public Dwarf createDwarf(string name)
        {
            return new Dwarf(name);
        }
    }
}
