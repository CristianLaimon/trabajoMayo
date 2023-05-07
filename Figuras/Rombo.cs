﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Rombo : Figura
    {
        private int diagonalMayor;
        private int diagonalMenor;

        public Rombo() : base()
        {
            diagonalMayor = 0;
            diagonalMenor = 0;
        }

        public Rombo(int lado, double area, double perimetro, int diagonalMayor, int diagonalMenor) : base(lado, area, perimetro)
        {
            this.diagonalMayor = diagonalMayor;
            this.diagonalMenor = diagonalMenor;
        }

        public int DiagonalMayor { get => diagonalMayor; set => diagonalMayor = value; }
        public int DiagonalMenor { get => diagonalMenor; set => diagonalMenor = value; }

        public override double CalcularArea()
        {
            Area = (diagonalMayor * diagonalMenor) / 2;
            return Area;
        }

        public override double CalcularPerimetro()
        {
            double lados = Math.Sqrt(Math.Pow((diagonalMenor/2),2) + Math.Pow((diagonalMayor/2),2));
            Perimetro = lados * 4;
            return Perimetro;
        }

        public override void DibujarPoligono(PictureBox pictureBox1)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (diagonalMenor/2), 10), 
                                new Point(10 , 10 + (diagonalMayor / 2)), 
                                new Point(10 + (diagonalMenor / 2), 10 + diagonalMayor), 
                                new Point(10 + diagonalMenor, 10 + (diagonalMayor / 2)) };
            papel.DrawPolygon(lapiz, points);
        }
    }
}
