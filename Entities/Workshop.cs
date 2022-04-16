namespace SantasWorkshop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Workshop
    {
        private List<Toy> toys;
        private List<Dwarf> dwarves;

        public Workshop()
        {
            this.toys = new List<Toy>();
            this.dwarves = new List<Dwarf>();
        }

        public IList<Toy> Toys => toys.AsReadOnly();
        public IList<Dwarf> Dwarves => dwarves.AsReadOnly();


        public Toy GetToy(string type)
        {
            var currentToy = toys.FirstOrDefault(x => x.GetType().Name == type);

            if(currentToy != null)
            {
                this.toys.Remove(currentToy);
            }

            return currentToy;

        }

        public void AddToy(Toy toy)
        {
            this.toys.Add(toy);
        }
      
        public void AddDwarf(Dwarf dwarf)
        {
            this.dwarves.Add(dwarf);
        }

    }
}
