using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Trapecio : Figuras
    {
        private int baseMayor;
        private int baseMenor;
        private int altura;

        public Trapecio() : base()
        {
            baseMayor = 0;
            baseMenor = 0;
            altura = 0;
        }

        public Trapecio(int lado, double area, double perimetro, int baseMayor, int baseMenor, int altura) : base(lado, area, perimetro)
        {
            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.altura = altura;
        }

        public int BaseMayor { get => baseMayor; set => baseMayor = value; }
        public int BaseMenor { get => baseMenor; set => baseMenor = value; }
        public int Altura { get => altura; set => altura = value; }

        //public override void CalcularArea(int altura, int baseMayor, int baseMenor)
        //{
        //    Area = ((baseMayor + baseMenor) / 2) * altura;
        //}

        //public override void CalcularPerimetro(int baseMayor, int baseMenor, int altura) 
        //{
        //    int algo = (int)Math.Sqrt(Math.Pow(((10 + baseMayor / 2 + baseMenor / 2) - (10 + baseMayor)) , 2) + Math.Pow(((10) - 10 + altura) , 2));

        //    Perimetro = baseMayor + baseMenor + (Lado * 2);
        //}

        public override void DibujarPoligono(PictureBox pictureBox1, int baseMayor, int baseMenor, int altura) //Base menor no puede ser más grande que base mayor.
        {
            if (baseMayor >= baseMenor)
            {
                Graphics papel;
                papel = pictureBox1.CreateGraphics();
                papel.Clear(Color.FromArgb(191, 205, 219));
                Pen lapiz = new Pen(Color.Black, 2);
                Point[] points = {  new Point(10, 10 + altura),
                                    new Point(10 + baseMayor, 10 + altura),
                                    new Point(10 + baseMayor/2 + baseMenor/2, 10),
                                    new Point(10 + baseMayor/2 - baseMenor/2, 10) };
                papel.DrawPolygon(lapiz, points);
            }
            else
            {
                MessageBox.Show("Error, la base menor es más grande que la mayor, intenta con una medida más pequeña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
