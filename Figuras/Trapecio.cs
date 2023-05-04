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
        private Trapecio trapecio1;

        public Trapecio() : base()
        {
            baseMayor = 0;
            baseMenor = 0;
            altura = 0;
            Trapecio1 = new Trapecio();
        }

        public Trapecio(int lado, double area, double perimetro, int baseMayor, int baseMenor, int altura) : base(lado, area, perimetro)
        {
            this.baseMayor = baseMayor;
            this.baseMayor = baseMenor;
            this.altura = altura;
        }

        public int BaseMayor { get => baseMayor; set => baseMayor = value; }
        public int BaseMenor { get => baseMenor; set => baseMenor = value; }
        public int Altura { get => altura; set => altura = value; }
        internal Trapecio Trapecio1 { get => trapecio1; set => trapecio1 = value; }

        public override void CalcularArea()
        {
            trapecio1.Area = ((trapecio1.baseMayor + trapecio1.baseMenor) / 2) * trapecio1.altura;
        }

        public override void CalcularPerimetro()
        {
            trapecio1.Perimetro = trapecio1.baseMayor + trapecio1.baseMenor + (trapecio1.Lado * 2);
        }
    }
}
