namespace SantasWorkshop.Command
{
    using SantasWorkshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WriteMagicWordCommand : Command
    {
        private Santa santa;
        private IneedItem item;

        public WriteMagicWordCommand(Santa santa, IneedItem item)
        {
            this.santa = santa;
            this.item = item;
        }

        public override void Execute()
        {
            this.santa.MagicBoard.WriteMagicWord(this.item);
        }
    }
}
