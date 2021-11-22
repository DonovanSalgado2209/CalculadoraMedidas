using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMedidas
{
    public class Operaciones
    {
        double x;
        double resultado;
        public Operaciones(double x)
        {
            this.x = x;
        }

        public double MetroToMi()
        {
            resultado =  x * 0.00062;
            return Math.Round(resultado, 4);
        }

        public double MetroToKm()
        {
            resultado = x * 0.001;
            return Math.Round(resultado, 4);
        }

        public double MetroToDm()
        {
            resultado = x * 10;
            return Math.Round(resultado, 4);
        }

        public double MetroToFt()
        {
            resultado = x * 3.28084;
            return Math.Round(resultado, 4);
        }
        public double MetroToYd()
        {
            resultado = x * 1.09361;
             return Math.Round(resultado, 4);
        }
        public double MetroToIn()
        {
            resultado = x * 39.37008;
            return Math.Round(resultado, 3);
        }
        public double MetroToNkt()
        {
            resultado = x * 0.00054;
            return Math.Round(resultado, 3);

        }
    }
}
