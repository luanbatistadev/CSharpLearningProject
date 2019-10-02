using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Conta
    {
        private long numero;
        private double saldo;
        private double limite;

        public long Numero { get => numero; set => numero = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double Limite { get => limite; set => limite = value; }
    }
}
