using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Herramientas
    {
    #region randomGenerators
        private int randomNumber(int valActual, int valMin)
        {
            Random rn = new Random();
            int num = -valActual + valMin;
            return rn.Next(num, 200);
        }
        private int randomNumber(bool opc, int valActual, int valMin)
        {
            if (!opc)
            {
                Random rn = new Random();
                int num = -valActual + valMin;
                return rn.Next(num, 0);
            }
            else 
            {
                Random rn = new Random();
                return rn.Next(0, 20000);
            }
        }
        private bool wordIsPositive()
        {
            Random rn = new Random();
            if(rn.Next(0, 1) == 1)
                return true;
            else
                return false;
        }
        
        public string[] wordGenerator(int valActual, int valMin)
        {
            string[] wordNumber = new string[2];
            Random rn = new Random();
            int num = rn.Next(0, 7);
            bool isPositive = wordIsPositive();

            if (wordIsPositive())
            {
                //Reemplazar texto vacio con frases positivas
                switch (num)
                {
                    case 1:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, 0, 0));
                        break;
                    case 2:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, 0, 0));
                        break;
                    case 3:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, 0, 0));
                        break;
                    case 4:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, 0, 0));
                        break;
                    case 5:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, 0, 0));
                        break;
                    case 6:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, 0, 0));
                        break;
                    case 7:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, 0, 0));
                        break;
                }
            }
            else
            {
                //Reemplazar texto vacio con frases negativas
                switch (num)
                {
                    case 1:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, valActual, valMin));
                        break;
                    case 2:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, valActual, valMin));
                        break;
                    case 3:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, valActual, valMin));
                        break;
                    case 4:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, valActual, valMin));
                        break;
                    case 5:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, valActual, valMin));
                        break;
                    case 6:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, valActual, valMin));
                        break;
                    case 7:
                        wordNumber[0] = "";
                        wordNumber[1] = Convert.ToString(randomNumber(isPositive, valActual, valMin));
                        break;
                }
            }
            return wordNumber;
        }
    #endregion
    #region Validations
        //valActual es para el valor actual de las acciones de x cosa, valMin es para el valor minimo que pueden tener las acciones de la x cosa
        public int randomNumberValidate(int valActual, int valMin)
        {
            int val = randomNumber(valActual,valMin);
            bool stop = true; ;
            while (stop)
            {
                val = randomNumber(valActual, valMin);
                if (valActual - val < valMin)
                    stop = true;
                else 
                    stop = false;
            }
            return val;
        }
        
        //opc si true, es para los mensajes positivos, como "es hora de comprar acciones" y esto retornara un numero random positivo
        //opc si es false, lo contrario
        public int randomNumberValidate(int valActual, int valMin, bool opc)
        {
            int val = randomNumber(opc, valActual, valMin);
            bool stop = true; ;
            while (stop)
            {
                val = randomNumber(opc, valActual, valMin);
                if (valActual - val < valMin)
                    stop = true;
                else
                    stop = false;
            }
            return val;
        }
    #endregion
    }
}
