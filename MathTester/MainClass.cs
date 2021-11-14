using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTester
{
    public class MainClass
    {

        public static Roots Discrement(double a, double b, double c)
        {
            
            double discrement = (b * b) - (4 * a * c);
            if(discrement>0)
            {
                double answer1 = (-b + Math.Sqrt(discrement)) / (2 * a);
                double answer2 = (-b - Math.Sqrt(discrement)) / (2 * a);
                Roots DBTN = new Roots(answer1, answer2);
                return DBTN;
            }
            else if(discrement==0)
            {
                double dd = -b / (2*a);
                Roots DBTN = new Roots(dd, double.NaN);
                return DBTN;
            }
            else
            {
                Roots DBTN = new Roots(double.NaN, double.NaN);
                return DBTN;
            }
        }
    }
}