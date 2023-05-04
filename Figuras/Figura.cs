using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Figura
    {
        private int lado;
        private double area;
        private double perimetro;
        private Graphics papel;

        public Figura()
        {
            lado = 0;
            area = 0;
            perimetro = 0;
        }

        public Figura(int lado, double area, double perimetro)
        {
            this.lado = lado;
            this.area = area;
            this.perimetro = perimetro;
        }

        public int Lado { get => lado; set => lado = value; }
        public double Area { get => area; set => area = value; }
        public double Perimetro { get => perimetro; set => perimetro = value; }
        public Graphics Papel { get => papel; set => papel = value; }

        public virtual void CalcularArea()
        {

        }

        public virtual void CalcularPerimetro()
        {

        }

        public virtual void DibujarPoligono(PictureBox pictureBox1)
        {
            Papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            Point[] arreglo = new Point[1];
            papel.DrawPolygon(lapiz, arreglo);
        }
    }
}
