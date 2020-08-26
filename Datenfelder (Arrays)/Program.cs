using System;using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Datenfelder__Arrays_
{
    class Program
    {
        #region Arrays
        static void Main(string[] args)
        {
            int[] elements = new int[] { 23, 9, 7 };

            long[] lngVar = new long[4];
            string[] strArr = new string[2];
            // Wertezuweisung
            lngVar[0] = 230;
            lngVar[1] = 4711;
            lngVar[3] = 77;
            strArr[0] = "C#";
            strArr[1] = "macht Spaß!";
            // Konsolenausgabe
            Console.WriteLine("lngVar[0] = {0}", lngVar[0]);
            Console.WriteLine("lngVar[1] = {0}", lngVar[1]);
            Console.WriteLine("lngVar[2] = {0}", lngVar[2]);
            Console.WriteLine("lngVar[3] = {0}", lngVar[3]);
            Console.WriteLine("StrArr[0] = {0}", strArr[0]);
            Console.WriteLine("strArr[1] = {0}", strArr[1]);

            Console.ReadKey();

            #endregion

            #region Mehrdimensionale Arrays

            // Zweidimensional 2 Reihen, 3 Spalten
            int[,] point = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Dreidimensional 2 Reihen, 3 Spalten, 4 Elemente
            int[,,] element =
            {
                {
                    { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 0, 1, 2 }, { 3, 4, 5, 6 }
                },
                {
                    { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 0, 1, 2 }, { 3, 4, 5, 15 }
                }

            };

       

            #endregion

           
            #region Festlegung der Array-Größe zur Laufzeit

            int[] liste;
          
            //Eingabe der Arrays Größe
           
            Console.WriteLine("Geben sie die Anahl der Elemente ein");
           
            int number = Convert.ToInt32(Console.ReadLine());
           
            //initialisierung des Arrays
           
            liste = new int[number];
           
            // jedes Element des Arrays in einer Schleife durchaufen
            
            for (int i = 0; i < number; i++)
            {
                liste[i] = i * i;
                Console.WriteLine("liste[{0}] =  {1}", i, liste[i]);        

            }
           
            Console.ReadLine();
            #endregion

            #region Bestimmung der Arrays Obergrenze

           

            int[,] ele = new int[20, 45]; 
            
            Console.WriteLine(ele.GetLength(1));
            Console.WriteLine(ele.Length);

            Console.ReadLine();

            #endregion


            #region Verzweigte Arrays

            // Verzweigte Arrays sind Arrays die ihrerseits wieder Arrays beinhalten.

            int[][] myArr =
            {
                new int[] {1,2,3},
                new int[] {1,2,3,4},
                new int[] {1,2},
                new int[] {1,2,3,4,5}

            };


            #endregion


        }


    }
}
