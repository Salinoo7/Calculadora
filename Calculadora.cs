using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        
        public double Somar(double valor1, double valor2)
        {
            double total = valor1 + valor2;
            return total;
        }

        public double Subtrair(double valor1, double valor2)
        {
            double total = valor1 - valor2;
            return total;
        }

        public double Multiplicar(double valor1, double valor2)
        {
            double total = valor1 * valor2;
            return total;
        }

        public double Dividir(double valor1, double valor2)
        {
            double total = valor1 / valor2;
            return total;
        }

        
    }
}