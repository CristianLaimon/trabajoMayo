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
        private double altura;

        public Triangulo() : base()
        {
            altura = 0;
            Puntos = new Point[3];
        }

        public Triangulo(int lado, double area, double perimetro, int altura) : base(lado, area, perimetro)
        {
            this.altura = altura;
            Puntos = new Point[3];
        }

        public double Altura { get => altura; set => altura = value; }

        public override void CalcularArea(int lado)
        {
            Altura = Math.Sqrt(Math.Pow(lado, 2) - (Math.Pow((lado/2), 2)));
            Area = (lado * Altura) / 2;
        }

        public override void CalcularPerimetro(int lado)
        {
            Perimetro = lado * 3;
        }

        public override void DibujarPoligono(PictureBox pictureBox1, int lado)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Puntos[0] = new Point(10 + (lado / 2), 10);
            Puntos[1] = new Point(10, 10 + lado);
            Puntos[2] = new Point(10 + lado, 10 + lado);
            papel.DrawPolygon(lapiz, Puntos);
        }

        public override void MoverArriba(PictureBox pictureBox1, int lado)
        {

            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Puntos[0].Y -= 40;
            Puntos[1].Y -= 40;
            Puntos[2].Y -= 40;

            papel.DrawPolygon(lapiz, Puntos);
        }

        public override void MoverIzquierda(PictureBox pictureBox1, int lado)
        {

            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Puntos[0].X -= 40;
            Puntos[1].X -= 40;
            Puntos[2].X -= 40;
            papel.DrawPolygon(lapiz, Puntos);
        }

        public override void MoverAbajo(PictureBox pictureBox1, int lado)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Puntos[0].Y += 40;
            Puntos[1].Y += 40;
            Puntos[2].Y += 40;
            papel.DrawPolygon(lapiz, Puntos);
        }


        public override void MoverDerecha(PictureBox pictureBox1, int lado)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Puntos[0].X += 40;
            Puntos[1].X += 40;
            Puntos[2].X += 40;
            papel.DrawPolygon(lapiz, Puntos);
        }

    }
}
