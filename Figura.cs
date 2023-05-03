using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo
{
    internal abstract class Figura
    {
        private List<int> lados;
        private int perimetro;
        private int altura;
        private double area;

        public List<int> Lados { get => lados; set => lados = value; }
        public int Perimetro { get => perimetro; set => perimetro = value; }
        public double Area { get => area; set => area = value; }
        public int Altura { get => altura; set => altura = value; }

        public abstract double CalcularArea();
        public abstract int CalcularPerimetro();
    }
}
