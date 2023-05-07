using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal abstract class Figura
    {
        private int lado;
        private double area;
        private double perimetro;

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

        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();
        
        public abstract void DibujarPoligono(PictureBox pictureBox1);

        public abstract void Mover(PictureBox pictureBox1, int lado);

        public abstract void MoverIzquierda(PictureBox pictureBox1, int lado);

        public abstract void MoverAbajo(PictureBox pictureBox1, int lado);

        public abstract void MoverDerecha(PictureBox pictureBox1, int lado);

    } 
}
