namespace SantasWorkshop.Factories
{
    using SantasWorkshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class IneedItemFactory
    {
        public IneedItem createItem(string type)
        {
            IneedItem item = null;
            if (type == "IneedWheels")
            {
                item = new IneedBicycles();
            }
            else if (type == "IneedDolls")
            {
                item = new IneedDolls();
            }
            else
            {
                Console.WriteLine("Unknown item type");
            }

            return item;


        }
    }
}
