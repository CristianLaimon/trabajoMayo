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

        public override void DibujarPoligono(PictureBox pictureBox1, int largo, int x, int y)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = { new Point(10 + (largo / 2), 10), new Point(10, 10 + largo), new Point(10 + largo, 10 + largo) };
            papel.DrawPolygon(lapiz, points);
        }

    }
}
