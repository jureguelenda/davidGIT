using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            string resultado;
            bool tipo;

            Console.WriteLine("Digite o número");
            num1 = double.Parse(Console.ReadLine());

            resultado = num1 < 0 ? "O numero é negativo" : "O numero é positivo";
            tipo = num1 > 0 ? true : false;

            Console.WriteLine(resultado); Console.WriteLine(tipo);
        }

    }
}
