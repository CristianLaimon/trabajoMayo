using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Hexagono : Figuras
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

        public override void CalcularPerimetro(int lado)
        {
            Perimetro = lado * 6;
        }

        public override void CalcularArea(int lado)
        {
            Apotema = Math.Sqrt(Math.Pow(lado, 2) - (Math.Pow((lado / 2), 2)));
            Area = Perimetro * Apotema / 2;
        }

        public override void DibujarPoligono(PictureBox pictureBox1, int largo)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (largo / 2), 10), 
                                new Point(10 , 10 + (largo / 2)), 
                                new Point(10 + (largo / 2), 10 + largo), 
                                new Point(10 + (3 * largo / 2), 10 + largo), 
                                new Point(10 + (2 * largo), 10 + (largo / 2)), 
                                new Point(10 + (3 * largo / 2), 10) };
            papel.DrawPolygon(lapiz, points);
        }

        //public override void MoverArriba(PictureBox pictureBox1, int lado, ref int cuanto)
        //{
        //    cuanto += 5;
        //    Graphics papel;
        //    papel = pictureBox1.CreateGraphics();
        //    papel.Clear(Color.FromArgb(191, 205, 219));
        //    Pen lapiz = new Pen(Color.Black, 2);
        //    Point[] points = {  new Point(10 + (lado / 2), 10 - cuanto),
        //                        new Point(10 , 10 + (lado / 2 - cuanto)),
        //                        new Point(10 + (lado / 2), 10 + lado - cuanto),
        //                        new Point(10 + (3 * lado / 2), 10 + lado - cuanto),
        //                        new Point(10 + (2 * lado), 10 + (lado / 2) - cuanto),
        //                        new Point(10 + (3 * lado / 2), 10 - cuanto) };
        //    papel.DrawPolygon(lapiz, points);
        //}

        //public override void MoverIzquierda(PictureBox pictureBox1, int lado, ref int cuanto)
        //{
        //    cuanto += 5;
        //    Graphics papel;
        //    papel = pictureBox1.CreateGraphics();
        //    papel.Clear(Color.FromArgb(191, 205, 219));
        //    Pen lapiz = new Pen(Color.Black, 2);
        //    Point[] points = {  new Point(10 + (lado / 2) - cuanto, 10),
        //                        new Point(10 - cuanto, 10 + (lado / 2)),
        //                        new Point(10 + (lado / 2) - cuanto, 10 + lado),
        //                        new Point(10 + (3 * lado / 2) - cuanto, 10 + lado),
        //                        new Point(10 + (2 * lado) - cuanto, 10 + (lado / 2)),
        //                        new Point(10 + (3 * lado / 2) - cuanto, 10) };
        //    papel.DrawPolygon(lapiz, points);
        //}

        public override void MoverAbajo(PictureBox pictureBox1, int lado, ref int cuanto)
        {
            cuanto += 5;
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (lado / 2), 10 + cuanto),
                                new Point(10 , 10 + (lado / 2 + cuanto)),
                                new Point(10 + (lado / 2), 10 + lado + cuanto),
                                new Point(10 + (3 * lado / 2), 10 + lado + cuanto),
                                new Point(10 + (2 * lado), 10 + (lado / 2) + cuanto),
                                new Point(10 + (3 * lado / 2), 10 + cuanto) };
            papel.DrawPolygon(lapiz, points);
        }

        public override void MoverDerecha(PictureBox pictureBox1, int lado, ref int cuanto)
        {
            cuanto += 5;
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (lado / 2) + cuanto, 10),
                                new Point(10 + cuanto, 10 + (lado / 2)),
                                new Point(10 + (lado / 2) + cuanto, 10 + lado),
                                new Point(10 + (3 * lado / 2) + cuanto, 10 + lado),
                                new Point(10 + (2 * lado) + cuanto, 10 + (lado / 2)),
                                new Point(10 + (3 * lado / 2) + cuanto, 10) };
            papel.DrawPolygon(lapiz, points);
        }
    }
}
