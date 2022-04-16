namespace SantasWorkshop.Factories
{
    using SantasWorkshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class WorkshopFactory
    {
        public Workshop createWorkshop()
        {
            return new Workshop();
        }
    }
}
