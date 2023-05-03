using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoMayo.Figuras
{
    internal class Trapecio : Figura
    {
        private int dMayor, dMenor;

        public Trapecio(int dMayor, int dMenor, int altura) : base()
        {
            this.dMayor = dMayor;
            this.dMenor = dMenor;
            this.Altura = altura;
            Lados.Add(dMayor); // (0) de la lista
            Lados.Add(dMenor); // (1) de la lista
        }

        private void CalcularRestoLados()
        {

        }

    }
}
