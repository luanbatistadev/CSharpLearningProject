using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Animal
    {
        public void Acordar()
        {
            Console.WriteLine("Acordei!");
        }
        public void Comer()
        {
            Console.WriteLine("Comendo!");
        }
        public void Dormir()
        {
            Console.WriteLine("Dormindo!");
        }
        public string Nome { get; set; }
    }
}
