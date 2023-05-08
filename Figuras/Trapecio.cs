using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Trapecio : Figura
    {
        private int baseMayor;
        private int baseMenor;
        private int altura;

        public Trapecio() : base()
        {
            baseMayor = 0;
            baseMenor = 0;
            altura = 0;
            Puntos = new Point[4];
        }

        public Trapecio(int lado, double area, double perimetro, int baseMayor, int baseMenor, bool creado, int altura) : base(lado, area, perimetro, creado)
        {
            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.altura = altura;
            Puntos = new Point[4];
        }

        public int BaseMayor { get => baseMayor; set => baseMayor = value; }
        public int BaseMenor { get => baseMenor; set => baseMenor = value; }
        public int Altura { get => altura; set => altura = value; }


        public override double CalcularArea()
        {
            Area = ((baseMayor + baseMenor) / 2) * altura;
            return Area;
        }

        public override double CalcularPerimetro()
        {
            int ladoLateral = (int)Math.Sqrt(Math.Pow(((10 + baseMayor / 2 + baseMenor / 2) - (10 + baseMayor)), 2) + Math.Pow(((10) - 10 + altura), 2));

            Perimetro = baseMayor + baseMenor + (ladoLateral * 2);
            return Perimetro;
        }

        public override void DibujarPoligono(PictureBox pictureBox1)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.FromArgb(191, 205, 219));
            Pen lapiz = new Pen(Color.Black, 2);
            Puntos[0] = new Point(10, 10 + altura);
            Puntos[1] = new Point(10 + baseMayor, 10 + altura);
            Puntos[2] = new Point(10 + baseMayor / 2 + baseMenor / 2, 10);
            Puntos[3] = new Point(10 + baseMayor / 2 - baseMenor / 2, 10);
            papel.DrawPolygon(lapiz, Puntos);
        }

        public override void MoverArriba(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el trapecio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Puntos[0].Y - 40 > 0)
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
                MessageBox.Show("Aun no ha creado el trapecio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Puntos[1].X - 40 > 0)
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
                MessageBox.Show("Aun no ha creado el trapecio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    Puntos[3].Y += 40;
                    papel.DrawPolygon(lapiz, Puntos);
                }
            }
        }

        public override void MoverDerecha(PictureBox pictureBox1)
        {
            if (Creado == false)
            {
                MessageBox.Show("Aun no ha creado el trapecio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Puntos[2].X + 40 > 660)
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

        public override bool Validarse()
        {
            if( baseMenor > baseMayor)
            {
                MessageBox.Show("La base menor no puede valer mas que la mayor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }
    }
}
