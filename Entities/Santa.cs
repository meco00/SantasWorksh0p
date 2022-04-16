namespace SantasWorkshop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Santa
    {
        private MagicBoard magicBoard;
        private List<Toy> toys;

        public Santa()
        {
            magicBoard = new MagicBoard();
            toys = new List<Toy>();
        }

        public MagicBoard MagicBoard => this.magicBoard;
        public IList<Toy> Toys => this.toys.AsReadOnly();


        public void AddToy(Toy toy)
        {
            if(toy != null)
            {
                this.toys.Add(toy);
            }
            
        }

    }
}
