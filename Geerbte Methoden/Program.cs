using GeometricObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geerbte_Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Luftfahrzeug[] arr = new Luftfahrzeug[5];
            arr[0] = new Flugzeug();
            arr[1] = new Hubschrauber();
            arr[2] = new Hubschrauber();
            arr[3] = new Flugzeug();
            arr[4] = new Rakete();

            foreach (Luftfahrzeug item in arr)
                item.Starten();


            Console.ReadLine();
        }
    }
}
