using investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiBlioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "eu";
            cliente1.Capital = 1400;
            cliente1.Idade = 33;

            Cliente cliente2 = new Cliente();
            cliente2.Nome = "tu";
            cliente2.Capital = 1400;
            cliente2.Idade = 25;

            Cliente cliente3 = new Cliente();
            cliente3.Nome = "nois";
            cliente3.Capital = 140;
            cliente3.Idade = 37;
            List<Cliente> lista = new List<Cliente>();
            Investimento invest = new Investimento();
            lista.Add(cliente1);
            lista.Add(cliente2);
            lista.Add(cliente3);

            Console.WriteLine("Simulação");
            Console.WriteLine("Juros Acumulados"+ invest.retornarJurosAcumulado(lista,24).ToString());

            foreach(var item in lista)
            {
                Console.WriteLine($"cliente: {item.Nome}" +
                    $"juros: {invest.retornarJurosCliente(item, 24).ToString()}");
            }

            Console.WriteLine($"Media de Idade: {Cliente.mediaIdade(lista)}");

            Console.ReadKey();
        }

    }
}