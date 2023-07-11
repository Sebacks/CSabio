using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Herramientas
    {
       public int randomNumber()
        {
            Random rn = new Random();
            return rn.Next(-200,200);
        }
        public int randomNumber(bool opc)
        {
            if (opc)
            {
                Random rn = new Random();
                return rn.Next(-20000, 0);
            }
            else 
            {
                Random rn = new Random();
                return rn.Next(0, 20000);
            }
        }
        public bool wordIsPositive()
        {
            Random rn = new Random();
            if(rn.Next(0, 1) == 1)
                return true;
            else
                return false;
        }

    }
}
