using System;

namespace InlemningsUppgift2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin?");
            Double Elinhopp = Double.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Alma?");
            Double Almahopp = Double.Parse(Console.ReadLine());
            Console.WriteLine("Elin hoppade" + (Elinhopp - Almahopp) + "längre än alma");
        }
    }
}