using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Nacional
{
    class Cliente
    {
        public string Nome;
        public int Idade;
        public Conta conta;
        public CartaodeCredito cartaodecredito;

        public Cliente (string nome,Conta conta)
        {
            this.Nome = nome;
            this.conta = conta;

        }

    }
}
