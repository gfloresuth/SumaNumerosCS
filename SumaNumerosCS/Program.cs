using System;
using System.Collections.Generic;
using System.Text;

namespace SumaNumerosCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Mate m;
            m = new Mate();
            try
            {
                Console.Write("Primer Numero: ");
                m.EstablecerPrimerNumero(Console.ReadLine());
                Console.Write("Segundo Numero: ");
                m.EstablecerSegundoNumero(Console.ReadLine());

                m.CalcularSuma();

                Console.WriteLine("El resultado es: " + m.ObtenerResultado());
            }
            catch (Exception unError)
            {
                Console.WriteLine("Error: " + unError.Message);
            }
            finally
            {
                Console.WriteLine("Termino programa.");
            }
            Console.ReadKey();
        }
    }
}
