using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo
{
    internal abstract class Figura
    {
        private int lado, perimetro;
        private double area;
  
        public Figura()
        {
            lado = 0;
            perimetro = 0;
            area = 0;
        }

        public Figura(int lado, int perimetro)
        {
            this.lado = lado;
            this.perimetro = perimetro;
            area = 0;
        }

        public abstract double CalcularArea();
        public abstract int CalcularPerimetro();
    }
}
