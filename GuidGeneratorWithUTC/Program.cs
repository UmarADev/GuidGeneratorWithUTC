using System;

namespace GuidGeneratorWithUTC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userChoise = "";

            do
            {
                string guidGenerator = Guid.NewGuid().ToString();

                Console.WriteLine($"New Guid: {guidGenerator}");
                TextCopy.ClipboardService.SetText( guidGenerator );
                Console.WriteLine("Copied !");

            } while (userChoise == "y");
        }
    }
}

