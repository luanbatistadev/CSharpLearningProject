using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roblox_Corporation
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.nome = "Rafael";
            f1.salario = 500;

            f1.MostrarDados();
            f1.AumentarSalario();
            f1.MostrarDados();

            Console.ReadKey();
        }
    }
}
