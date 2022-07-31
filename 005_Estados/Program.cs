using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _005_ESTADOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regiões Brasileiras");
            Console.WriteLine("[1] Norte");
            var norte = new List<string>() { "Acre", "Amapá", "Amazonas", "Pará", "Rondônia", "Roraima", "Tocantins" };

            Console.WriteLine("[2] Nordeste");
            var nordeste = new List<string>() { "Alagoas", "Bahia", "Ceará", "Maranhão", "Paraíba", "Paraíba", "Pernambuco", "Piauí", "Rio Grande do Norte" };

            Console.WriteLine("[3] Centro-oeste");
            var centroOeste = new List<string>() { "Mato Grosso", "Mato Grosso do Sul", "Goías", "Distrito Federal" };

            Console.WriteLine("[4] Sudeste");
            var sudeste = new List<string>() { "São Paulo", "Rio de Janeiro", "Minhas Gerais", "Espírito Santo" };

            Console.WriteLine("[5] Sul");
            var sul = new List<string>() { "Paraná", "Santa Catarina", "Rio Grande do Sul" };

            Console.WriteLine("[6] Encerrar Programa");

            Console.Write("\nDigite sua Escolha: ");
            int escolha = Convert.ToInt16(Console.ReadLine().Trim());
            Console.Clear();
            Thread.Sleep(500);
            
            switch (escolha)
            {
                case 1: // Norte
                    foreach (var estado in norte) Console.WriteLine(estado.ToUpper());
                    break;
                case 2: // Nordeste
                    foreach (var estado in nordeste) Console.WriteLine(estado.ToUpper());
                    break;
                case 3: // Centro-Oeste
                    foreach (var estado in centroOeste) Console.WriteLine(estado.ToUpper());
                    break;
                case 4: // Sudeste
                    foreach (var estado in sudeste) Console.WriteLine(estado.ToUpper());
                    break;
                case 5: // Sul
                    foreach (var estado in sul) Console.WriteLine(estado.ToUpper());
                    break;
                case 6: // Sair do Programa
                    Console.WriteLine("Saindo do programa...");
                    break;
            }
            Console.ReadLine();
        }
    }
}
