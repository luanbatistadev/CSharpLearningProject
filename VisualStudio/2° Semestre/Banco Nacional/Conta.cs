using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Nacional
{
    class Conta
    {
        public int numc;
        public double saldo;
        public double limite;
        public Cliente cliente;
        public Agencia agencia;

        public luan MyProperty { get; set; }

        public Conta (int numc, Agencia agencia)
        {
            this.numc = numc;
            this.agencia = agencia;
            saldo = 0;
            limite = 100;
        }
        public Conta (int numc)this
        {

        }
        public void Sacar(double valor)
        {
            if (valor >0)
            {
                if (valor < saldo)
                {
                    saldo = saldo - valor;
                    Console.WriteLine("\nSaque realizado com sucesso! \nRetire seu dinheiro!");
                }
                else
                {
                    Console.WriteLine("\nSaldo insuficiente!");   
                }
            }
            else
            {
                Console.WriteLine("Valor deve ser maior que '0'!");
            }
        }
        public void Depositar(double valor)
        {
            if (valor>0)
            {
                saldo = saldo + valor;
                Console.WriteLine("Deposito realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nValor deve ser maior que '0'!");
            }
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine("Saldo: {0:c2}", saldo);
        }
        public void Transferir(Conta destino, double valor)
        {
            if (valor > 0)
            {
                if (valor < saldo)
                {
                    saldo = saldo - valor;
                    Console.WriteLine("\nTransferencia realizada com sucesso! \nRetire seu dinheiro!");
                }
                else
                {
                    Console.WriteLine("\nSaldo insuficiente!");
                }
            }
            else
            {
                Console.WriteLine("Valor deve ser maior que '0'!");
            }
            saldo = saldo - valor;
            destino.saldo = destino.saldo + valor;
        }
    }
}
