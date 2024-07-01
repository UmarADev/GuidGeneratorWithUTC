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

               
            } while (userChoise == "y");
        }
    }
}

