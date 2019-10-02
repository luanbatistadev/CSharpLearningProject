using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace CalcularArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            double x=0;
            double y=0;
            bool cond1 = true, cond2 = true;
            Console.WriteLine("\t\t\t---Calcular Area do Retangulo---");
            while(cond1)
            {
            Console.Write("\nInforme o valor de x: ");
            x = double.Parse(Console.ReadLine());
                if (x>0)
                {
                    cond1 = false;
                }
                else
                {
                    Console.WriteLine("O valor de ser maior que 0!");
                        cond1 = true;
                }
            }
            while (cond2)
            {
            Console.Write("Informe o valor de y: ");
            y = double.Parse(Console.ReadLine());
                if (y > 0)
                {
                    cond2 = false;
                }
                else
                {
                    Console.WriteLine("O valor de ser maior que 0!");
                    cond2 = true;
                }
            }
            Retangulo ret = new Retangulo(x, y);
            ret.CalcularArea();
            Console.WriteLine("\nArea: "+ret.Area);
            SoundPlayer musica = new SoundPlayer();
            musica.SoundLocation= "C:/Users/06477929236/Downloads/teste2.wav";
            musica.Load();
            musica.Play();
            
            Console.ReadKey();
        }
    }
}
