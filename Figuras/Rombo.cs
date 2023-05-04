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
        private Rombo rombo1;

        public Rombo() : base()
        {
            diagonalMayor = 0;
            diagonalMenor = 0;
            Rombo1 = new Rombo();
        }

        public Rombo(int lado, double area, double perimetro, int diagonalMayor, int diagonalMenor) : base(lado, area, perimetro)
        {
            this.diagonalMayor = diagonalMayor;
            this.diagonalMenor = diagonalMenor;
        }

        public int DiagonalMayor { get => diagonalMayor; set => diagonalMayor = value; }
        public int DiagonalMenor { get => diagonalMenor; set => diagonalMenor = value; }
        internal Rombo Rombo1 { get => rombo1; set => rombo1 = value; }

        public override void CalcularArea()
        {
            rombo1.Area = (rombo1.diagonalMayor * rombo1.diagonalMenor) / 2;
        }

        public override void CalcularPerimetro()
        {
            rombo1.Perimetro = rombo1.Lado * 4;
        }
    }
}
