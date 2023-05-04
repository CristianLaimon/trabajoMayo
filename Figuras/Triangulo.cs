using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajoMayo.Figuras
{
    internal class Triangulo : Figuras
    {
        private int altura;

        public Triangulo() : base()
        {
            altura = 0;
        }

        public Triangulo(int lado, double area, double perimetro, int altura) : base(lado, area, perimetro)
        {
            this.altura = altura;
        }

        public int Altura { get => altura; set => altura = value; }

        public override void CalcularArea()
        {
            Area = (Lado * Altura) / 2;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = Lado * 3;
        }

        public override void DibujarPoligono(PictureBox pictureBox1, int largo)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black, 3);
            Point point1 = new Point(10, 10);
            Point point2 = new Point(10+largo, 10+largo);
            Point point3 = new Point(10+largo*2, 10+largo*2);
            Point[] points = { point1, point2, point3 };
            papel.DrawPolygon(lapiz, points);
        }
    }
}
