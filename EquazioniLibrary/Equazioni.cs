using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool response = true;
            if(a==0)
            {
                response = false;
            }
            return response;
        }

        public static bool IsInconsisted(double a, double b)
        {
            bool response = false;
            if(a==0 && b!=0)
            {
                response = true;
            }
            return response;
        }

        public static bool IsNotDetermined(double a, double b)
        {
            bool response = false;

            if(a==0 && b==0)
            {
                response = true;
            }
            return response;
        }

        public static bool IsDegree2(double a)
        {
            bool response = true;

            if (a == 0)
            {
                response = false;
            }
            return response;
        }

        public static double Delta(double a, double b, double c)
        {
            return (b * b) - 4 * a * c;
        }

        public static string EquationDegree1(double a, double b)
        {
            string response = "";
            if (IsNotDetermined(a,b))
            {
                response = "Indeterminato";
            }
            else if(IsInconsisted(a,b))
            {
                response = "Impossibile";
            }
            else
            {
                response = Convert.ToString(b / a);
            }
            return response;
        }

        public static string EquationDegree2(double a, double b, double c)
        {
            string response = "";
            if (a == 0 && b == 0 && c == 0)
            {
                response = "Indeterminato";
            }
            else if (!IsDegree2(a))
            {
                response = EquationDegree1(b, c);
            }
            else if (Delta(a, b, c) < 0)
            {
                response = "Impossibile";
            }
            else if (Delta(a, b, c) == 0)
            {
                response = Convert.ToString((-b + Math.Sqrt((b * b) - 4 * a * c)) / 2 * a);
                
            }
            else
            {
                double x = (-b + Math.Sqrt((b * b) - 4 * a * c)) / 2 * a;
                double y = (-b - Math.Sqrt((b * b) - 4 * a * c)) / 2 * a;
                response = ($"{x} e {y}");

            }
            return response;
        }


    }
}
