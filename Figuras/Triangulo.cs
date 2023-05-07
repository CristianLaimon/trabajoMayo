﻿using System;
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
        }

        public Triangulo(int lado, double area, double perimetro, int altura) : base(lado, area, perimetro)
        {
            this.altura = altura;
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
            Point[] points = {  new Point(10 + (lado / 2), 10), 
                                new Point(10, 10 + lado), 
                                new Point(10 + lado, 10 + lado) };
            papel.DrawPolygon(lapiz, points);
        }

        public override void MoverArriba(PictureBox pictureBox1, int lado, ref int cuanto)
        {
            cuanto += 5;
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (lado / 2), 10 - cuanto),
                                new Point(10, 10 + lado - cuanto),
                                new Point(10 + lado, 10 + lado - cuanto) };
            papel.DrawPolygon(lapiz, points);
        }

        public override void MoverIzquierda(PictureBox pictureBox1, int lado, ref int cuanto)
        {
            cuanto += 5;
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (lado / 2) - cuanto, 10),
                                new Point(10 - cuanto, 10 + lado),
                                new Point(10 + lado - cuanto, 10 + lado) };
            papel.DrawPolygon(lapiz, points);
        }

        public override void MoverAbajo(PictureBox pictureBox1, int lado, ref int cuanto)
        {
            cuanto += 5;
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (lado / 2), 10 + cuanto),
                                new Point(10, 10 + lado + cuanto),
                                new Point(10 + lado, 10 + lado + cuanto) };
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
                                new Point(10 + cuanto, 10 + lado),
                                new Point(10 + lado + cuanto, 10 + lado) };
            papel.DrawPolygon(lapiz, points);
        }

    }
}
