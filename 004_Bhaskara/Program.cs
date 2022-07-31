using System;

namespace _004_Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("A: "); double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("B: "); double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("C: "); double c = Convert.ToDouble(Console.ReadLine());

                double delta = (b * b) - 4 * a * c;
                if (a == 0 || delta < 0)
                {
                    Console.Clear(); Console.WriteLine("Impossível calcular!"); 
                    break;
                }

                Console.WriteLine($"\nDelta = {delta:N2}\n");
                double x1 = (-b + (Math.Sqrt(delta))) / (2 * a); Console.WriteLine($"x1: {x1:N2}");
                double x2 = (-b - (Math.Sqrt(delta))) / (2 * a); Console.WriteLine($"x2: {x2:N2}");
            }
            Console.ReadLine();
        }
    }
}
