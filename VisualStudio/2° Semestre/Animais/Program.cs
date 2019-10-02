using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Animal an1 = new Animal();
            an1.Nome = "Luan";
            an1.Acordar();
            an1.Comer();
            an1.Dormir();*/

            Mamifero m1 = new Mamifero();
            Console.WriteLine("\t\t\t---Dados Mamifero---\n");
            m1.Nome = "Mamifero";
            m1.Acordar();
            m1.Comer();
            m1.Dormir();

            Morcego bat = new Morcego();
            Console.WriteLine("\t\t\t---Dados Morcego---\n");
            bat.Nome = "Batman";
            bat.Acordar();
            bat.Comer();
            bat.Voar();
            bat.Dormir();

            Baleia wil = new Baleia();
            Console.WriteLine("\t\t\t---Dados Baleia---\n");
            wil.Nome = "Free Willy";
            wil.Acordar();
            wil.Comer();
            wil.Nadar();
            wil.Dormir();

            Console.ReadKey();
        }
    }
}
