using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    class Retangulo
    {
        //Atributos Encapsulados
        private double x, y, area;
        //Propriedades
        public double X { get; set; }
        public double Y { get; set; }
        public double Area { get; set; }
        //Construtor
        public Retangulo(double x, double y)
        {
            X = x;
            Y = y;
        }
        //Método
        public void CalcularArea()
        {
           Area =  X * Y;
        }
    }
}
