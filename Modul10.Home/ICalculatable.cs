using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.Home
{
    public interface ICalculatable
    {
        double Plus(double a, double b);
        double Umnozhit(double a, double b);
        double Minus(double a, double b);
        double Delit(double a, double b);
    }

    public class Calculator : ICalculatable
    {
        public double Plus(double a, double b)
        {
            return a + b;
        }

        public double Minus(double a, double b)
        {
            return a - b;
        }

        public double Umnozhit(double a, double b)
        {
            return a * b;
        }

        public double Delit(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }
    }

    internal class Calculatable
    {
        static void Main()
        {
            ICalculatable calculatable = new Calculator();
            double rslt1 = calculatable.Plus(7, 14);
            double rslt2 = calculatable.Umnozhit(19, 3);
            double rslt3 = calculatable.Minus(4, 8);
            double rslt4 = calculatable.Delit(40, 4);
            Console.WriteLine(rslt1);
            Console.WriteLine(rslt2);
            Console.WriteLine(rslt3);
            Console.WriteLine(rslt4);
            Console.ReadKey();
        }
    }
}
