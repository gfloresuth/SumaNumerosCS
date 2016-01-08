using System;
using System.Collections.Generic;
using System.Text;

namespace SumaNumerosCS
{
    public class Mate
    {
        public int PrimerNumero;
        public int SegundoNumero;
        private int Resultado;
        public void EstablecerPrimerNumero(string unValor)
        {
            PrimerNumero = int.Parse(unValor);
        }
        public void EstablecerSegundoNumero(string unValor)
        {
            SegundoNumero = int.Parse(unValor);
        }
        public void CalcularSuma()
        {
            Resultado = PrimerNumero + SegundoNumero;
        }
        public int ObtenerResultado()
        {
            return Resultado;
        }
    }
}
