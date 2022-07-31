using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_NomeInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();
            int inicio = nome.Length;

            Console.WriteLine();
            Console.WriteLine(nome.ToUpper().Trim());
            for (int i = 1; i < nome.Length + 1; i++)
            {
                inicio -= 1;
                Console.Write(nome.Substring(inicio, 1).ToUpper());
            }
            Console.ReadLine();
        }
    }
}