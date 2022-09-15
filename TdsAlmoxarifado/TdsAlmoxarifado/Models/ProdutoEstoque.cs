using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TdsAlmoxarifado.Models
{
    public class ProdutoEstoque : IEstoque
    {
        public bool verificarEstoque(PRODUTO produto, int qtd)
        {
            if(qtd <=produto.PROESTOQUE)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}