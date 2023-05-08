using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajoMayo.Figuras
{
    internal class Triangulo : Figura
    {
        private double altura;

        public Triangulo() : base()
        {
            altura = 0;
            Puntos = new Point[3];
        }

        public Triangulo(int lado, double area, double perimetro, bool creado, int altura) : base(lado, area, perimetro, creado)
        {
            this.altura = altura;
            Puntos = new Point[3];
        }

        public double Altura { get => altura; set => altura = value; }

        public override double CalcularArea()
        {
            Altura = Math.Sqrt(Math.Pow(Lado, 2) - (Math.Pow((Lado /2), 2)));
            Area = (Lado * Altura) / 2;
            return Area;
        }

        public override double CalcularPerimetro()
        {
            Perimetro = Lado * 3;
            return Perimetro;
        }

        public override void DibujarPoligono(PictureBox pictureBox1)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Puntos[0] = new Point(10 + (Lado / 2), 10);
            Puntos[1] = new Point(10, 10 + Lado);
            Puntos[2] = new Point(10 + Lado, 10 + Lado);
            papel.DrawPolygon(lapiz, Puntos);
        }

        public override void MoverArriba(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el triangulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Puntos[0].Y - 40 < 0)
                {
                    MessageBox.Show("Limite alcanzado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Graphics papel;
                    papel = pictureBox1.CreateGraphics();
                    papel.Clear(Color.FromArgb(191, 205, 219));
                    Pen lapiz = new Pen(Color.Black, 2);
                    Puntos[0].Y -= 40;
                    Puntos[1].Y -= 40;
                    Puntos[2].Y -= 40;
                    papel.DrawPolygon(lapiz, Puntos);
                }
            }
        }

        public override void MoverIzquierda(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el triangulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Puntos[1].X - 40 < 0)
                {
                    MessageBox.Show("Limite alcanzado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Graphics papel;
                    papel = pictureBox1.CreateGraphics();
                    papel.Clear(Color.FromArgb(191, 205, 219));
                    Pen lapiz = new Pen(Color.Black, 2);
                    Puntos[0].X -= 40;
                    Puntos[1].X -= 40;
                    Puntos[2].X -= 40;
                    papel.DrawPolygon(lapiz, Puntos);
                }
            }
        }

        public override void MoverAbajo(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el triangulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Puntos[1].Y + 40 > 220)
                {
                    MessageBox.Show("Limite alcanzado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Graphics papel;
                    papel = pictureBox1.CreateGraphics();
                    papel.Clear(Color.FromArgb(191, 205, 219));
                    Pen lapiz = new Pen(Color.Black, 2);
                    Puntos[0].Y += 40;
                    Puntos[1].Y += 40;
                    Puntos[2].Y += 40;
                    papel.DrawPolygon(lapiz, Puntos);
                }
            }
        }

        public override void MoverDerecha(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el triangulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Puntos[2].X + 40 > 798)
                {
                    MessageBox.Show("Limite alcanzado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Graphics papel;
                    papel = pictureBox1.CreateGraphics();
                    papel.Clear(Color.FromArgb(191, 205, 219));
                    Pen lapiz = new Pen(Color.Black, 2);
                    Puntos[0].X += 40;
                    Puntos[1].X += 40;
                    Puntos[2].X += 40;
                    papel.DrawPolygon(lapiz, Puntos);
                }
            }
        }

        public override bool Validarse()
        {
            if (Lado == 0)
            {
                MessageBox.Show("Aun no ingresa la medida del lado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
