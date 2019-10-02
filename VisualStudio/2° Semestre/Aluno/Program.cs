using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("\t\t\tEscola Raio de Luz");
            Console.ForegroundColor = ConsoleColor.Black;
            Aluno n1 = new Aluno();
            n1.nome = "Luana Muriel BABY";
            Aluno rg1 = new Aluno();
            rg1.rg = "1639344";
            Aluno data1 = new Aluno();
            data1.datadenascimento = "03/03/2003";
            Console.WriteLine("\n\tSeu nome é "+n1.nome+"\n\tSeu RG é "+rg1.rg+"\n\tVocê nasceu em "+data1.datadenascimento);
            Funcionario fun1 = new Funcionario();
            fun1.nome = "Luan Rafael";
            Console.ReadKey();

        }
    }
}
