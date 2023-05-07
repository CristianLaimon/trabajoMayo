using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal abstract class Figura
    {
        public Figura()
        {
            Lado = 0;
            Area = 0;
            Perimetro = 0;
        }

        public Figura(int lado, double area, double perimetro)
        {
            this.Lado = lado;
            this.Area = area;
            this.Perimetro = perimetro;
        }

        public int Lado { get; set; }
        public double Area { get; set; }
        public double Perimetro { get ; set ; }

        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();
        
        public abstract void DibujarPoligono(PictureBox pictureBox1);

        public abstract void MoverArriba(PictureBox pictureBox1, int lado);

        public abstract void MoverIzquierda(PictureBox pictureBox1, int lado);

        public abstract void MoverAbajo(PictureBox pictureBox1, int lado);

        public abstract void MoverDerecha(PictureBox pictureBox1, int lado);

    } 
}
