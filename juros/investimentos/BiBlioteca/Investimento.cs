using investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiBlioteca
{
     public class Investimento
    {
        public double ValorInvestido { get; set; }
        public int meses { get; set; }
        public List<Cliente> Cliente { get; set; }

        public double retornarJurosAcumulado(List<Cliente> clientes, int meses)
        {


            double jurosAcumulado = 0;
            foreach(var item in clientes)
            {
                jurosAcumulado = jurosAcumulado + retornarJurosCliente(item, 24);

            }

            return jurosAcumulado;
        }

        public double retornarJurosCliente(Cliente cliente, int meses)
        {
            double montante = cliente.Capital * (Math.Pow((1 + 0.07), meses / 12));
            double juros = montante - cliente.Capital;
            return Math.Round(juros,2);
        }
    }
}
