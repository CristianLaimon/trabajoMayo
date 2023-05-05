﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Hexagono : Figuras
    {
        private int apotema;

        public Hexagono() : base()
        {
            apotema = 0;
        }

        public Hexagono(int lado, double area, double perimetro, int apotema) : base(lado, area, perimetro)
        {
            this.apotema = apotema;
        }

        public int Apotema { get => apotema; set => apotema = value; }

        public override void CalcularArea()
        {
            Area = Perimetro * apotema / 2;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = Lado * 6;
        }

        public override void DibujarPoligono(PictureBox pictureBox1, int largo, int x, int y)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (largo / 2), 10), 
                                new Point(10 , 10 + (largo / 2)), 
                                new Point(10 + (largo / 2), 10 + largo), 
                                new Point(10 + (3 * largo / 2), 10 + largo), 
                                new Point(10 + (2 * largo), 10 + (largo / 2)), 
                                new Point(10 + (3 * largo / 2), 10) };
            papel.DrawPolygon(lapiz, points);
        }
    }
}
