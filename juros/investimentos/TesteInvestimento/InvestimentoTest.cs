
using BiBlioteca;
using investimento;
using System;


namespace TesteInvestimento
{
    [TestClass]
    public class InvestimentoTest
    {
        [TestMethod]
        public void JurosdeClienteCorreto()
        {
            double esperado=202.86;
            double resultado=0;

            Cliente cliente = new Cliente();
            cliente.Capital = 1400;

            Investimento invest = new Investimento();
            resultado = invest.retornarJurosCliente(cliente, 24);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Jurosde3Clientes()
        {
            double esperado = 608.58;
            double resultado = 0;

            Cliente cliente1 = new Cliente();
            cliente1.Capital = 1400;

            Cliente cliente2 = new Cliente();
            cliente2.Capital = 1400;

            Cliente cliente3 = new Cliente();
            cliente3.Capital = 1400;

            List<Cliente> lista = new List<Cliente>();
            lista.Add(cliente1);
            lista.Add(cliente2);
            lista.Add(cliente3);

            Investimento invest = new Investimento();
            resultado = invest.retornarJurosAcumulado(lista, 24);

            Assert.AreEqual(esperado, resultado);
        }
    }
}