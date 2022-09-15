using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdsAlmoxarifado.Models
{
    internal interface IEstoque
    {
        bool verificarEstoque(PRODUTO produto, int qtd);
    }
}
