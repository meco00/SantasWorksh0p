namespace SantasWorkshop
{
    using SantasWorkshop.Command;
    using SantasWorkshop.Factories;
    using SantasWorkshop.Observer;
    using System;

   public class Program
    {
        static void Main(string[] args)
        {

            var workshopFactory = new WorkshopFactory();
            var santaFactory = new SantaFactory();
            var dwarfFactory = new DwarfFactory();
            var toyFactory = new ToyFactory();
            var itemFactory = new IneedItemFactory();

            var workshop = workshopFactory.createWorkshop();
            var santa = santaFactory.createSanta();

            RemoteController remote = new RemoteController();

            var santaObserver = new SantaObserver(remote);

            for (int i = 1; i <= 3; i++)
            {
                var dwarf = dwarfFactory.createDwarf("dwarf" + i);
                var registerDwarfCommand = new RegisterDwarfCommand(santaObserver,dwarf );
                remote.setCommand(registerDwarfCommand);
                remote.pressButton();
            }

            ;

            for (int i = 0; i < 3; i++)
            {
                var addToyCommand = new AddToyToWorkshopCommand(workshop, toyFactory.createToy("Bicycle"));
                remote.setCommand(addToyCommand);
                remote.pressButton();
            }

            var writeMagicWordCommand = new WriteMagicWordCommand(santa, itemFactory.createItem("IneedWheels"));
            remote.setCommand(writeMagicWordCommand);
            remote.pressButton();

            var neededToyType = santa.MagicBoard.GetNeededToyType;

            var getToyForSantaCommand = new GetToyForSantaCommand(santa, workshop, neededToyType);
            santaObserver.NotifyObservers(getToyForSantaCommand);
  


            Console.WriteLine($"Workshop toys count : {workshop.Toys.Count}");
            Console.WriteLine($"Santa toys count : {santa.Toys.Count}");


        }
    }

}

