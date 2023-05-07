using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajoMayo.Figuras
{
    internal class Triangulo : Figura
    {
        private double altura;

        public Triangulo() : base()
        {
            altura = 0;
        }

        public Triangulo(int lado, double area, double perimetro, int altura) : base(lado, area, perimetro)
        {
            this.altura = altura;
        }

        public double Altura { get => altura; set => altura = value; }

        public override double CalcularArea()
        {
            Altura = Math.Sqrt(Math.Pow(Lado, 2) - (Math.Pow((Lado /2), 2)));
            Area = (Lado * Altura) / 2;
            return Area;
        }

        public override double CalcularPerimetro()
        {
            Perimetro = Lado * 3;
            return Perimetro;
        }

        public override void DibujarPoligono(PictureBox pictureBox1)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (Lado / 2), 10), 
                                new Point(10, 10 + Lado), 
                                new Point(10 + Lado, 10 + Lado) };
            papel.DrawPolygon(lapiz, points);
        }

        public override void MoverArriba(PictureBox pictureBox1, int lado)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (Lado / 2), 10 - 5),
                                new Point(10, 10 + Lado - 5),
                                new Point(10 + Lado, 10 + Lado - 5) };
            papel.DrawPolygon(lapiz, points);
        }

        public override void MoverIzquierda(PictureBox pictureBox1, int lado)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (lado / 2) - 5, 10),
                                new Point(10 - 5, 10 + lado),
                                new Point(10 + lado - 5, 10 + lado) };
            papel.DrawPolygon(lapiz, points);
        }

        public override void MoverAbajo(PictureBox pictureBox1, int lado)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (lado / 2), 10 + 5),
                                new Point(10, 10 + lado + 5),
                                new Point(10 + lado, 10 + lado + 5) };
            papel.DrawPolygon(lapiz, points);
        }

        public override void MoverDerecha(PictureBox pictureBox1, int lado)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (lado / 2) + 5, 10),
                                new Point(10 + 5, 10 + lado),
                                new Point(10 + lado + 5, 10 + lado) };
            papel.DrawPolygon(lapiz, points);
        }

    }
}
