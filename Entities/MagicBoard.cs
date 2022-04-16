namespace SantasWorkshop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MagicBoard
    {
        private List<string> magicWords;

        public MagicBoard()
        {
            magicWords = new List<string>();
        }

        public void WriteMagicWord(IneedItem @object)
        {
            var result = "";
            if (@object == null)
            {
                return;
            }
            var objectName = @object.GetType().Name;
            if (objectName== "IneedDolls")
            {
                result = "Doll";
            }
            else if (objectName == "IneedBicycles")
            {
                result = "Bicycle";
            }

            if(result != "")
            {
                magicWords.Add(result);
                PrintMagicWord(objectName);
            }

        }

        private void PrintMagicWord(string word)
        {
            Console.WriteLine("Magic Board : " + word);
        }
        public string GetNeededToyType => this.magicWords.Count > 0 ? this.magicWords[this.magicWords.Count - 1]: "";

        

    }
}
