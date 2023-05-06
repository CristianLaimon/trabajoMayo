using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Figuras
    {
        private int lado;
        private double area;
        private double perimetro;

        public Figuras()
        {
            lado = 0;
            area = 0;
            perimetro = 0;
        }

        public Figuras(int lado, double area, double perimetro)
        {
            this.lado = lado;
            this.area = area;
            this.perimetro = perimetro;
        }

        public int Lado { get => lado; set => lado = value; }
        public double Area { get => area; set => area = value; }
        public double Perimetro { get => perimetro; set => perimetro = value; }

        public virtual void CalcularArea()
        {

        }

        public virtual void CalcularPerimetro()
        {

        }

        public virtual void DibujarPoligono(PictureBox pictureBox1, int lado, int lado2, int lado3)
        {

        }

        public virtual void DibujarPoligono(PictureBox pictreBox1, int lado, int lado2, int lado3, int lado4)
        {

        }

    } 
}
