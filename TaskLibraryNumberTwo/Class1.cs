using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibraryNumberTwo
{
    public class Equation
    {
        public double[] CalculateEquationArea(double a, double b, double c)
        {
            if (a == 0) throw new System.ArgumentException("А не может быть равно нулю");
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                return new double[0]; // Нет корней
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);// Первый корень
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);// Второй корень
                return new double[] { root1, root2 };
            }
        }
    }
}
