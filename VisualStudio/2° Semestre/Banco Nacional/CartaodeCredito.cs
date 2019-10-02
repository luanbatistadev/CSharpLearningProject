using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Nacional
{
    class CartaodeCredito
    {
        public string numCartao;
        public Cliente cliente;

        public CartaodeCredito(string numCartao, Cliente cliente)
        {
            this.numCartao = numCartao;
            this.cliente = cliente;
        }
    }
}
