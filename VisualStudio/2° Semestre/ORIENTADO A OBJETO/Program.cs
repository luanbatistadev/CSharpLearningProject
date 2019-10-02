using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORIENTADO_A_OBJETO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("\t\t\tBanco Internacional do Brasil");
            Console.ForegroundColor = ConsoleColor.Black;
            Cliente cliente = new Cliente();
            cliente.nome = "Luan Rafael Batista Ramos";
            cliente.codigo = 2456;
            Console.WriteLine("\n\tSeu nome: " + cliente.nome + ".\n\tSeu codigo é: " + cliente.codigo);

            CartaoDeCredito c1 = new CartaoDeCredito();
            c1.numero = "1234.5678.9012.3456";
            c1.datadevalidade = "10/24";
            CartaoDeCredito c2 = new CartaoDeCredito();
            c2.numero = "9876.5432.1098.7654";
            c2.datadevalidade = "08/24";
            Console.WriteLine("\n\tCartao 1:\nNúmero é: " + c1.numero + "\nData de validade: " + c1.datadevalidade);
            Console.WriteLine("\n\tCartao 2:\nNúmero é: " + c2.numero + "\nData de validade: " + c2.datadevalidade);

            Agencia n = new Agencia();
            n.numero = "0123";
        }
    }
}
