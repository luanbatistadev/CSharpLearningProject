using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoDeCredito c1 = new CartaoDeCredito();
            c1.numero = 123456789;
            c1.datadevalidade = "10/24";
            CartaoDeCredito c2 = new CartaoDeCredito();
            c2.numero = 987654321;
            c2.datadevalidade = "08/24";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("\t\t\tBanco Internacional do Brasil");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\tCartao 1:\nNúmero é: "+c1.numero+"\nData de validade: "+c1.datadevalidade);
            Console.WriteLine("\n\tCartao 2:\nNúmero é: " + c2.numero + "\nData de validade: " + c2.datadevalidade);
        }
    }
}
