using System;
using PaceAPI;

namespace APITester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Distance:");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Time (HH:MM:SS):");
            string t = Console.ReadLine();

            Console.WriteLine("Enter Unit:");
            string u = (Console.ReadLine());

            Pace p = new Pace(TimeSpan.Parse(t), d, Unit.Parse(u));

            int i = 0;
            foreach (TimeSpan time in p.Paces)
            {
                Console.WriteLine(p.Distances[i] + ": " + time);
                i++;
            }
        }
    }
}
