using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculApp
{
    public class ClsOps
    {
        public double Sumar(double n1, double n2)
        {
            double s;
            s = n1 + n2;
            return s;

        }

        public double Restar(double n1, double n2)
        {
            double s;
            s = n1 - n2;
            return s;

        }

        public double Multiplicar(double n1, double n2)
        {
            double s;
            s = n1 * n2;
            return s;

        }

        public double Dividir(double n1, double n2)
        {
            double s;
            s = n1 / n2;
            return s;

        }

        public double Elevar(double n1)
        {
            double s;
            s = n1 * n1;
            return s;

        }

        public double PorCiento(double n1, double n2)
        {
            double s;
            s = (n1 * n2) / 100;
            return s;

        }

        public double Negativo(double n1)
        {
            double s;
            s = n1 * -1;
            return s;

        }
    }
}
