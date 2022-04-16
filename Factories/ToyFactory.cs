namespace SantasWorkshop.Factories
{
    using SantasWorkshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class ToyFactory
    {
        public Toy createToy(string type)
        {
            Toy toy = null;
            if(type== "Doll")
            {
                toy = new Doll();
            }
            else if(type == "Bicycle")
            {
                toy = new Bicycle();
            }
            else
            {
                Console.WriteLine("Unknown toy type");
            }

            return toy;


        }
    }
}
