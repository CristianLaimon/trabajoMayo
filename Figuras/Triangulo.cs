using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Triangulo : Figura
    {
        private int altura;
        private Triangulo triangulo1;

        public Triangulo() : base()
        {
            altura = 0;
            Triangulo1 = new Triangulo();
        }

        public Triangulo(int lado, double area, double perimetro, int altura) : base(lado, area, perimetro)
        {
            this.altura = altura;
        }

        public int Altura { get => altura; set => altura = value; }
        internal Triangulo Triangulo1 { get => triangulo1; set => triangulo1 = value; }

        public override void CalcularArea()
        {
            triangulo1.Area = (triangulo1.Lado * triangulo1.altura) / 2;
        }

        public override void CalcularPerimetro()
        {
            triangulo1.Perimetro = triangulo1.Lado * 3;
        }

        public override void DibujarPoligono(PictureBox pictureBox1)
        {

        }
    }
}
