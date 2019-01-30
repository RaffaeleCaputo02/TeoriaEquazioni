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

        
    }
}
