using System;

namespace AntSimulation
{
    public class Ant
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Ant(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move()
        {
            
            Console.WriteLine($"Мурашка рухається на координатах ({X}, {Y})");
        }
    }

    public class AntColony
    {
        private Ant[] ants;
        private Random random;

        public AntColony(int size)
        {
            ants = new Ant[size];
            random = new Random();
            InitializeAnts();
        }

        private void InitializeAnts()
        {
            
           
            for (int i = 0; i < ants.Length; i++)
            {
                int x = random.Next(0, 100); 
                int y = random.Next(0, 100); 
                ants[i] = new Ant(x, y);
            }
        }

        public void Simulate()
        {
            
            Console.WriteLine("Імітація руху мурашок в колонії");
            foreach (var ant in ants)
            {
                ant.Move();
            }
        }
    }
}
