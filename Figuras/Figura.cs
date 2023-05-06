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

        public virtual void CalcularArea(int lado)
        {

        }

        public virtual void CalcularArea(int lado, int lado1)
        {

        }

        public virtual void CalcularPerimetro(int lado)
        {

        }

        public virtual void CalcularPerimetro(int lado, int lado1)
        {

        }

        public virtual void DibujarPoligono(PictureBox pictureBox1, int lado)
        {

        }

        public virtual void DibujarPoligono(PictureBox pictureBox1, int lado, int lado2)
        {

        }

        public virtual void DibujarPoligono(PictureBox pictureBox1, int lado, int lado1, int lado2)
        {

        }

        public virtual void MoverArriba(PictureBox pictureBox1, int lado, string direccion, int cuanto)
        {

        }
        public virtual void MoverIzquierda(PictureBox pictureBox1, int lado, string direccion, int cuanto)
        {

        }
        public virtual void MoverAbajo(PictureBox pictureBox1, int lado, string direccion, int cuanto)
        {

        }
        public virtual void MoverDerecha(PictureBox pictureBox1, int lado, string direccion, int cuanto)
        {

        }
    } 
}
