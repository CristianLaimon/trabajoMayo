using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Hexagono : Figura
    {
        private double apotema;

        public Hexagono() : base()
        {
            apotema = 0;
            Puntos = new Point[6];
        }

        public Hexagono(int lado, double area, double perimetro, bool creado, int apotema) : base(lado, area, perimetro, creado)
        {
            this.apotema = apotema;
            Puntos = new Point[6];
        }

        public double Apotema { get => apotema; set => apotema = value; }

        public override double CalcularPerimetro()
        {
            Perimetro = Lado * 6;
            return Perimetro;
        }

        public override double CalcularArea()
        {
            Apotema = Math.Sqrt(Math.Pow(Lado, 2) - (Math.Pow((Lado / 2), 2)));
            Area = Perimetro * Apotema / 2;
            return Area;
        }

        public override void DibujarPoligono(PictureBox pictureBox1)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Puntos[0] = new Point(10 + (Lado / 2), 10);
            Puntos[1] = new Point(10, 10 + (Lado / 2));
            Puntos[2] = new Point(10 + (Lado / 2), 10 + Lado);
            Puntos[3] = new Point(10 + (3 * Lado / 2), 10 + Lado);
            Puntos[4] = new Point(10 + (2 * Lado), 10 + (Lado / 2));
            Puntos[5] = new Point(10 + (3 * Lado / 2), 10);
            papel.DrawPolygon(lapiz, Puntos);
        }

        public override void MoverArriba(PictureBox pictureBox1)
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
                Puntos[3].Y -= 40;
                Puntos[4].Y -= 40;
                Puntos[5].Y -= 40;
                papel.DrawPolygon(lapiz, Puntos);
            }
        }

        public override void MoverIzquierda(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el hexagono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    Puntos[3].X -= 40;
                    Puntos[4].X -= 40;
                    Puntos[5].X -= 40;
                    papel.DrawPolygon(lapiz, Puntos);
                }
            }
        }

        public override void MoverAbajo(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el hexagono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Puntos[2].Y + 40 > 219)
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
                    Puntos[3].Y += 40;
                    Puntos[4].Y += 40;
                    Puntos[5].Y += 40;
                    papel.DrawPolygon(lapiz, Puntos);
                }
            }
        }

        public override void MoverDerecha(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el hexagono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Puntos[4].X + 40 > 659)
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
                    Puntos[3].X += 40;
                    Puntos[4].X += 40;
                    Puntos[5].X += 40;
                    papel.DrawPolygon(lapiz, Puntos);
                }
            }
        }
    }
}
