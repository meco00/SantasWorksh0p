namespace SantasWorkshop.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class RemoteController
    {
        private Command command;

        public Command getCommand()
        {
            return command;
        }

        public void setCommand(Command command)
        {
            this.command = command;
        }

        public void pressButton()
        {
            if (this.command == null)
            {
                Console.WriteLine("No command set");
                return;
            }
            this.command.Execute();
        }





    }
}
