using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Hexagono : Figura
    {
        private double apotema;

        public Hexagono() : base()
        {
            apotema = 0;
        }

        public Hexagono(int lado, double area, double perimetro, int apotema) : base(lado, area, perimetro)
        {
            this.apotema = apotema;
        }

        public double Apotema { get => apotema; set => apotema = value; }

        public override double CalcularPerimetro() => Lado * 6;

        public override double CalcularArea()
        {
            Apotema = Math.Sqrt(Math.Pow(Lado, 2) - (Math.Pow((Lado / 2), 2)));
            Area = Perimetro * Apotema / 2;
            return Area;
        }

        public override void DibujarPoligono(PictureBox pictureBox1)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (Lado / 2), 10), 
                                new Point(10 , 10 + (Lado / 2)), 
                                new Point(10 + (Lado / 2), 10 + Lado), 
                                new Point(10 + (3 * Lado / 2), 10 + Lado), 
                                new Point(10 + (2 * Lado), 10 + (Lado / 2)), 
                                new Point(10 + (3 * Lado / 2), 10) };
            papel.DrawPolygon(lapiz, points);
        }
    }
}
