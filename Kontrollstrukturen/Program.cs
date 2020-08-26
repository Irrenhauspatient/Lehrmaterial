using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
        #region if Anweisung

        Start:
            Console.WriteLine("Geben sie ihren Namen ein:");
            string name = Console.ReadLine();

            if (name =="")
            {
                Console.WriteLine("Haben sie keinen Namen?");
                Console.ReadLine();
                goto Start;
            }

            else
            {
                Console.WriteLine($"Ihr Name ist: \" {name} \" ");
                Console.ReadLine();
            }

            StartNumber:
            Console.WriteLine("Geben sie eine Zahl zwischen 0 und 9 ein.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer ==0 || answer <= 9)
            {
                Console.WriteLine($"Bravo sie beherschen einfache Anweisungen, ihre Zahl lautet: {answer} ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Falsche Eingabe bitte versuchen sie es erneut");
                Console.ReadLine();
                goto StartNumber;
            }

            #endregion

            #region switch Statement

            string message = "Treffen sie eine Wahl: \n\n";
            message += "(N) - Neues Spiel \n";
            message += "(A) - Altes Spiel fortsetzen \n";
            message += "(E) - Beenden \n";
            
            Console.WriteLine(message);
            Console.Write("Ihre Wahl lautet:");
            string choice = Console.ReadLine().ToUpper();

            switch (choice)
            {
                case "N":
                    Console.WriteLine("Neues Spiel wird gestartet.");
                    break;
                case "A":
                    Console.WriteLine("Spiel wird geladen.");
                    break;
                case "E":
                    Console.WriteLine("Spiel wird beendet.");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
            #endregion

            #region for Schleife

            Console.WriteLine("Geben sie die Anzahl der Schleifen an");
            int counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"Schleife {i} ");
            }

            Console.ReadLine();

            #endregion

            #region Baumstruktur mit for

            Console.WriteLine("Geben sie die Anzahl der Stufen ein:");
            int stufen = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= stufen; i++)
            {
                for (int j = 1; j  <= stufen -1; j++) 
                Console.Write(" ");

                for (int j = 1; j <= i*2-1; j++) 
                Console.Write("M");
                Console.WriteLine("");
               
            }
            Console.ReadLine();

            #endregion

            #region Vorzeitiges beenden eine for Schleife

            int start = 100;
            Console.WriteLine($"Die Schleife zählt bis {start} wo soll sie aufhören?");
            int end = Convert.ToInt32(Console.ReadLine());

            for (int d = 0; d < start; d++)
            {
                
                
                if (d == end)
                break;
                Console.WriteLine($"Schäfchen nummer {0}", d);


            }
            Console.ReadLine();


            #endregion
        }
    }

}
