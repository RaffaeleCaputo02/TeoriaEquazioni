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

        public static bool IsNotDetermined(double a, double b)
        {
            bool response = false;
            if(a==0 && b!=0)
            {
                response = true;
            }
            return response;
        }

        public static bool IsInconsisted(double a, double b)
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
            bool response = false;

            if (a == 0)
            {
                response = true;
            }
            return response;
        }
    }
}
