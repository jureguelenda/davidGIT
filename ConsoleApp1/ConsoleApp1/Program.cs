using System;

namespace Aula01
{
    class Program
    {
        static void Mn(string[] args)
        {
            double num1 = 0, num2 = 0, num3 = 0;

            Console.WriteLine("Digite o primeiro número");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número");
            num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("O primeiro numero é o maior");

            }

            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("O segundo numero é o maior");
            }

            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("O terceiro numero é o maior");
            }

            Console.ReadKey();
        }
    }
}
