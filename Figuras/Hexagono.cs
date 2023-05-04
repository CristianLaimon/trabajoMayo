using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Hexagono : Figura
    {
        private int apotema;
        private Hexagono hexagono1;

        public Hexagono() : base()
        {
            apotema = 0;
            Hexagono1 = new Hexagono();
        }

        public Hexagono(int lado, double area, double perimetro, int apotema) : base(lado, area, perimetro)
        {
            this.apotema = apotema;
        }

        public int Apotema { get => apotema; set => apotema = value; }
        internal Hexagono Hexagono1 { get => hexagono1; set => hexagono1 = value; }

        public override void CalcularArea()
        {
            hexagono1.Area = (hexagono1.Perimetro * hexagono1.apotema) / 2;
        }

        public override void CalcularPerimetro()
        {
            hexagono1.Perimetro = hexagono1.Lado * 6;
        }
    }
}
