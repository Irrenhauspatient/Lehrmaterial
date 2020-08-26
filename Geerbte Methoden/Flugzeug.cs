using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public abstract class Luftfahrzeug
    {


        public string Hersteller { get; set; }
        public int Baujahr { get; set; }
        public abstract void Starten();
       
        
        public void DoSomething(Luftfahrzeug lfzg)
        {
            if (lfzg != null)
            {
                if (lfzg is Flugzeug)
                    Console.WriteLine($"Spannweite ist: {((Flugzeug)lfzg).Spannweite}");

                else if (lfzg is Hubschrauber)
                    Console.WriteLine($"Rotor : {((Hubschrauber)lfzg).Rotor}");

                else
                    Console.WriteLine("Ungültiges Objekt");
                Console.ReadLine();
            }

           
        }



    }

        public class Flugzeug : Luftfahrzeug
        {
            public override void Starten()
            {
            Console.WriteLine($"Das Flugzeug startet.");
            }

            public double Spannweite { get; set; }

        }

        public class Hubschrauber : Luftfahrzeug
        {
           public override void Starten()
            {
            Console.WriteLine($"Der Hubschrauber startet.");
            }

            public double Rotor { get; set; }
        }

        public class Rakete : Luftfahrzeug
        {
        public override void Starten()
        {
            Console.WriteLine($"Die Rakete startet, Schub: {Schub}");
        }

        public double Schub { get; set; } = 300;
        }
         
}
