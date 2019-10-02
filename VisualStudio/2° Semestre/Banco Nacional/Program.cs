using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Nacional
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*Crie uma classe chamada Gerente para definir os
            objetos que representarão os gerentes do banco. Defina
dois métodos de aumento salarial nessa classe. O primeiro
deve aumentar o salário com uma taxa fixa de 10%. O
segundo deve aumentar o salário com uma taxa variável.
Teste os métodos de aumento salarial definidos na classe
Gerente. */
            #endregion
            #region
            /*Cliente c1 = new Cliente();
            c1.Nome = "Luan Rafael Batista Ramos";
            c1.Idade = 17;*/

            /*CartaodeCredito cc1 = new CartaodeCredito();
            cc1.numCartao = "12345678";
            cc1.cliente = c1;
            Agencia a1 = new Agencia();
            a1.num = 1234;
            Conta co1 = new Conta();
            co1.numc = 987654;
            co1.agencia = a1;
            co1.cliente = c1;
            co1.saldo = 1000;
            co1.limite = 100;
            c1.conta = co1;

            Console.WriteLine("\nNome: " + c1.Nome);
            Console.WriteLine("Saldo: " + c1.conta.saldo);
            c1.conta.Depositar(100);
            Console.WriteLine("Saldo: "+c1.conta.saldo);*/
            #endregion
            #region
            /*Funcionario f1 = new Funcionario();
            f1.nome = "Rafael";
            f1.salario = 500;

            f1.MostrarDados();
            f1.AumentarSalario();
            f1.MostrarDados();*/
            #endregion
            #region
            /*Gerente g1 = new Gerente();
            g1.salario = 12000;

            Console.WriteLine("\nSalario gerente: "+g1.salario);
            g1.AumentarSalario(20);
            Console.WriteLine("\nSalario gerente reajustado: "+g1.salario);*/
            #endregion
            #region
            Agencia caixa = new Agencia(1825);
            Conta cc1 = new Conta(23345, caixa);
            Cliente cl1 = new Cliente("Samara", cc1);
            cl1.Nome = "daniele";
            CartaodeCredito visa = new CartaodeCredito("123456789",cl1);
            cl1.cartaodecredito = visa;
            Console.WriteLine("Nome Cliente: "+cl1.Nome);
            Console.WriteLine("Numero conta: " + cl1.conta.numc);
            Console.WriteLine("Numero agencia: " + cl1.conta.agencia.num);
            Console.WriteLine("Saldo: " + cl1.conta.saldo);
            Console.WriteLine("Limite: " + cl1.conta.limite);
            Console.WriteLine("Numero cartao de credito: " + cl1.cartaodecredito.numCartao);

            Console.ReadKey();
            #endregion

        }
    }
}
