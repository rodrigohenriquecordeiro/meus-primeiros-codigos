using System;
using System.Collections.Generic;
using System.Threading;

namespace _002_Meses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meses\n");

            var meses = new List<string>() {"01 - Janeiro", "02 - Fevereiro", "03 - Março", "04 - Abril", "05 - Maio", "06 - Junho",
                "07 - Julho", "08 - Agosto", "09 - Setembro", "10 - Outubro", "11 - Novembro", "12 - Dezembro"};

            foreach (var mes in meses) Console.WriteLine($"{mes}");

            Console.Write("\nDigite sua escolha: ");
            int escolha = Convert.ToInt16(Console.ReadLine());

            Console.Clear(); Thread.Sleep(1000);
            Console.WriteLine($"Você escolheu o mês de {meses[escolha - 1].Substring(5)}");

            Console.ReadLine();
        }
    }
}
