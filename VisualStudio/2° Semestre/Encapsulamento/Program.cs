using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            TestarConta();
            //TestarEncapsulamento(); 
        }

        private static void TestarConta()
        {
            Conta c1 = new Conta();
        }
        //static void TestarEncapsulamento()
        //    {
        //        Funcionario f1 = new Funcionario();
        //        f1.salario = 200;
        //        f1.nome = "Luan Rafael Batista Ramos";
        //        Console.WriteLine("Seu nome é: "+f1.nome+"\nE seu salario do mes é: "+f1.salario+".");
        //        Console.ReadKey();
        //    }
    }
}
