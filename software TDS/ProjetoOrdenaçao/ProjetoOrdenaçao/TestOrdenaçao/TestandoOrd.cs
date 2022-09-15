using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoOrdenaçao;

namespace TestOrdenaçao
{
    [TestClass]
    public class TestandoOrd
    {
        [TestMethod]
        public void TrocaTest()
        {
            bool esperado = true;
            bool resultado;
            Ordenacao ordem = new Ordenacao();
            int[] valores = ordem.trocaPosicao(2, 3);
            if ((valores[0] == 3) & (valores[1] == 2))
                resultado = true;
            else
                resultado = false;

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TrocaTestManual()
        {
            bool esperado = true;
            bool resultado;
            Ordenacao ordem = new Ordenacao();
            int[] valores = ordem.trocaPosicaoManual(2, 3);
            if ((valores[0] == 3) & (valores[1] == 2))
                resultado = true;
            else
                resultado = false;

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TrocaTestArray()
        {
            int[] esperado = new[] { 3, 2 };
            int[] resultado;
            Ordenacao ordem = new Ordenacao();
            resultado = ordem.trocaPosicaoManual(2, 3);

            CollectionAssert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void OrdemCrescente3ValoresPositivos()
        {
            int[] esperado = new[] { 1, 2,3 };
            int[] resultado;
            Ordenacao ordem = new Ordenacao();
            resultado = ordem.OrdemCrescente(new int[] {3,2,1});

            CollectionAssert.AreEqual(esperado, resultado);
        }
    }
}
