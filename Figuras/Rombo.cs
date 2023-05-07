using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Rombo : Figura
    {
        private int diagonalMayor;
        private int diagonalMenor;

        public Rombo() : base()
        {
            diagonalMayor = 0;
            diagonalMenor = 0;
            Puntos = new Point[4];
        }

        public Rombo(int lado, double area, double perimetro, bool creado, int diagonalMayor, int diagonalMenor) : base(lado, area, perimetro, creado)
        {
            this.diagonalMayor = diagonalMayor;
            this.diagonalMenor = diagonalMenor;
            Puntos = new Point[4];
        }

        public int DiagonalMayor { get => diagonalMayor; set => diagonalMayor = value; }
        public int DiagonalMenor { get => diagonalMenor; set => diagonalMenor = value; }

        public override double CalcularArea()
        {
            Area = (diagonalMayor * diagonalMenor / 2);
            return Area;
        }

        public override double CalcularPerimetro()
        {
            double lados = Math.Sqrt(Math.Pow((diagonalMenor/2),2) + Math.Pow((diagonalMayor/2),2));
            Perimetro = lados * 4;
            return Perimetro;
        }

        public override void DibujarPoligono(PictureBox pictureBox1)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Puntos[0] = new Point(10 + (diagonalMenor / 2), 10);
            Puntos[1] = new Point(10, 10 + (diagonalMayor / 2));
            Puntos[2] = new Point(10 + (diagonalMenor / 2), 10 + diagonalMayor);
            Puntos[3] = new Point(10 + diagonalMenor, 10 + (diagonalMayor / 2));
            papel.DrawPolygon(lapiz, Puntos);
        }

        public override void MoverArriba(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el rombo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    Puntos[3].Y -= 40;
                    papel.DrawPolygon(lapiz, Puntos);
                }
            }
        }

        public override void MoverIzquierda(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el rombo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    papel.DrawPolygon(lapiz, Puntos);
                }
            }
        }

        public override void MoverAbajo(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el rombo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    papel.DrawPolygon(lapiz, Puntos);
                }
            }
        }

        public override void MoverDerecha(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el rombo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Puntos[3].X + 40 > 659)
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
                    papel.DrawPolygon(lapiz, Puntos);
                }
            }
        }
    }
}
