using System;

namespace AntSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AntColony colony = new AntColony(10); 

            colony.Simulate();

            Console.WriteLine("Програма завершила роботу");
        }
    }
}
