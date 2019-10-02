using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roblox_Corporation
{
    class Funcionario
    {
        public string nome;
        public double salario;
        public void AumentarSalario(double valor)
        {
            salario = salario + valor;
            Console.WriteLine("\nSalario ajustado!");
        }
        public void AumentarSalario()
        {
            salario = salario + (salario*0.1);
        }
        public void MostrarDados()
        {
            Console.WriteLine("\nDados do Funcionario:");
            Console.WriteLine("Nome: {0}",nome);
            Console.WriteLine("Salario: {0:c2}",salario);
        }
    }
}
