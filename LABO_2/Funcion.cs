using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LABO_2
{
    public class Funcion
    {
        public static double multiplicacion (double num)
        {
            return 2 * num; 

        }

        public static void  Bitacora(string texto)
        {
            using (StreamWriter Respaldo = new StreamWriter(@"C:\Users\adrie\Documents\Visual Studio 2017\Respaldo\Respaldo.txt", true)) 
            {

                Respaldo.WriteLine(texto);
                Respaldo.Flush(); 

            }
        }
    }
}