using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {

        public static float Add(float num1, float num2) {

            if (float.IsInfinity(num1) || float.IsInfinity(num2)) {
                throw new Exception("la somma con infinito risulta sempre in infinito"); //decido arbitrariamente di non gestire funzioni a cui viene inserito anche solo un infinito
            }
            if ((num1 > 0 && num2 > float.MaxValue - num1) || (num2 > 0 && num1 > float.MaxValue - num2)) 
            {
                throw new Exception("overflow durante la somma");

            }
            if ((num1 < 0 && num2 < float.MinValue + num1) || (num2 < 0 && num1 < float.MinValue + num2)) 
            {
                throw new Exception("underflow durante la sottrazione");
            }

                return num1 + num2; }
            public static float Subtract(float num1, float num2) {

                if (float.IsInfinity(num1) || float.IsInfinity(num2))
                {
                    throw new Exception("la sottrazione con infinito risulta sempre in infinito"); //anche qui gestisco tutte le funzioni a cui viene passati infinito come una singola eccezione
                }
                if ((num1 > 0 && num2 < float.MinValue + num1) || (num1 < 0 && num2 > float.MaxValue + num1)) 
                {
                    throw new Exception("underflow durante la sottrazione");
                }
                if ((num1 < 0 && num2 > float.MaxValue + num1) || (num2 < 0 && num1 > float.MaxValue + num2))
                {
                    throw new Exception("overflow durante la sottrazione");
                }


                return num1 - num2; }



            public static float Divide(float num1, float num2) { 
                
                if (float.IsInfinity(num1) || float.IsInfinity(num2))
                {
                    throw new Exception("la sottrazione con infinito risulta sempre in infinito"); //anche qui gestisco tutte le funzioni a cui viene passati infinito come una singola eccezione
                }
                if( num2 == 0)
                { 
                    throw new Exception("non consideriamo divisioni in cui è presente uno 0"); 
                }

                if (num2 != 0 && Math.Abs(num1) > float.MaxValue * Math.Abs(num2))
                {
                    throw new Exception("Overflow durante la divisione");
                }

                if(num1 == 0) { return 0; }

                return num1 / num2; }




            public static float Multiply(float num1, float num2) {

            if (Math.Abs(num1) > float.MaxValue / Math.Abs(num2))
            {
                throw new Exception("Overflow durante la moltiplicazione");
            }
            return num1 * num2; }
        }
    }

