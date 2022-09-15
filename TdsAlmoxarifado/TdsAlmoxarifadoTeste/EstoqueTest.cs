using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TdsAlmoxarifado.Models;

namespace TdsAlmoxarifadoTeste
{
    [TestClass]
    public class EstoqueTeste
    {
        [TestMethod]
        public void temSaldoTrueValorMenor()
        {
            bool esperado = true;
            bool resultado = false;
            PRODUTO produto = new PRODUTO();
            produto.PROID = 1;
            produto.PROESTOQUE = 10;

            ProdutoEstoque validarEstoque = new ProdutoEstoque();
            if (validarEstoque.verificarEstoque(produto, 5) == true)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void temSaldoTrueValorIgual()
        {
            bool esperado = true;
            bool resultado = false;
            PRODUTO produto = new PRODUTO();
            produto.PROID = 1;
            produto.PROESTOQUE = 10;

            ProdutoEstoque validarEstoque = new ProdutoEstoque();
            if (validarEstoque.verificarEstoque(produto, 10) == true)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void temSaldoTrueValorMaior()
        {
            bool esperado = true;
            bool resultado = false;
            PRODUTO produto = new PRODUTO();
            produto.PROID = 1;
            produto.PROESTOQUE = 10;

            ProdutoEstoque validarEstoque = new ProdutoEstoque();
            if (validarEstoque.verificarEstoque(produto, 15) == true)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            Assert.AreEqual(esperado, resultado);
        }
    }
}
