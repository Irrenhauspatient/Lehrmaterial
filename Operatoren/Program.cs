using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operatoren

            int value1 = 30;
            int value2 = 55;
            int result = value1 + value2;

            WriteLine(result);
            ReadLine();

            int x = 100;
            int y = 17;
            WriteLine("Divisioon mit % - Ergebnis = {0}", x % y);

            ReadLine();

            float a = 100.35F;
            float b = 17.45F;
            WriteLine("Division mit % - Ergebnis {0}" ,  a %  b);

            ReadLine();

            double value = 3.0 / 4.0;
            WriteLine(value);

            ReadLine();



            #endregion

            #region Vergleichsoperatoren



            /* 
            
            Operator        Beschreibung
            
            a==b            (Vergleichsoperator) prüft,ob AUsdruck a Ausdruck b entspricht, und gibt in diesem fall True zurück.
            a!=b            Ergebnis der Operation ist true, wenn a ungleich b ist.
            a>b             Ergebnis ist true, wenn a größer als b ist.
            a<b             Ergebnis ist true, wenn a kleiner als b ist.
            a<=b            Ergebnis ist true, wenn a kleiner oder gleich b ist.
            a>=b            Ergebnis ist true, wenn a größer oder gleich b ist.

            */

            #endregion

            #region Logisher Operatoren

            #endregion

            #region Bitweise Operatoren

            #endregion

            #region Zuweisungsoperatoren

            #endregion

            #region Sonstige Operatoren

            #endregion

            #region Operator Vorrangregeln

            #endregion
        }


    }
}
