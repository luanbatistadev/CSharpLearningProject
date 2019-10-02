using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Nacional
{
    class Gerente
    {
        public double salario;
        public void AumentarSalario(double valor)
        {
            salario = salario + (salario * valor / 100);
        }
        public void AumentarSalario()
        {
            salario =salario+(salario * 0.10);
        }
    }
}
