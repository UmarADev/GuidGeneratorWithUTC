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

                DateTimeOffset utcTime = DateTimeOffset.UtcNow;
                Console.WriteLine(utcTime);

                Console.WriteLine("Do you want to continue? (y / n)");
                userChoise = Console.ReadLine().ToLower();
            } while (userChoise == "y");
        }
    }
}

