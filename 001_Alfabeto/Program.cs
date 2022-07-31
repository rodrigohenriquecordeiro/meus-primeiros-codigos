using System;

namespace _001_Alfabeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprimindo o Alfabeto com ajuda do FOR

            for (int i = 0; i < 26; i++)
            {
                char alfabeto = (char)65;  // 65 representa letra A maiúscula na tabela ASCII
                alfabeto += (char)+i;
                Console.WriteLine($"{i}. {alfabeto}");
            }
            Console.ReadKey();
        }
    }
}
