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
            this.baseMayor = baseMenor;
            this.altura = altura;
        }

        public int BaseMayor { get => baseMayor; set => baseMayor = value; }
        public int BaseMenor { get => baseMenor; set => baseMenor = value; }
        public int Altura { get => altura; set => altura = value; }

        public override void CalcularArea()
        {
            Area = ((baseMayor + baseMenor) / 2) * altura;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = baseMayor + baseMenor + (Lado * 2);
        }

        public override void DibujarPoligono(PictureBox pictureBox1, int largo, int baseMayor, int baseMenor)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Point[] points = {  new Point(10 + (baseMayor / 4), 10),  //No se respeta la medida de la base mayor, se está aumentando en un 1/5 al dibujarse del valor original.
                                new Point(10 , 10 + (baseMayor / 2)), 
                                new Point(10 + baseMayor, 10 + (baseMayor / 2)), 
                                new Point(10 + (3 * baseMayor/4), 10) };
            papel.DrawPolygon(lapiz, points);
        }
    }
}
