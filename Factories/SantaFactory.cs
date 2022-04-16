namespace SantasWorkshop.Factories
{
    using SantasWorkshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class SantaFactory
    {
        public Santa createSanta()
        {
            return new Santa();
        }
    }
}
