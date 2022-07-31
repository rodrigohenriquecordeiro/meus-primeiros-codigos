using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_ConversaoDataAmericana
{
    class Program
    {
        static void Main(string[] args)
        {
            // CultureInfo("en-US") Padrão Americano
            // CultureInfo("es-US") Padrão Brasileiro

            string dateContmatic = "12/31/2021";
            var dataContmaticConvertida = DateTime.Parse(dateContmatic, new CultureInfo("en-US"));
            Console.WriteLine($"Data Contmatic Convertida: {dataContmaticConvertida}\n");
            
            Console.WriteLine($"Dia: {dataContmaticConvertida.Day}");
            Console.WriteLine($"Mês: {dataContmaticConvertida.Month}");
            Console.WriteLine($"Ano: {dataContmaticConvertida.Year}");

            Console.ReadLine();
        }
    }
}
