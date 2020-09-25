using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GeometricObjects
{
    class Program 
    {
        static void Main(string[] args)
        {
     //     Document doc = new Document();
     //     doc.Copy();
     //     ICopy copy = doc;
     //     copy.Copy();
     //     IAdress adress = doc;
     //     adress.Copy();
     //     
     //     
     //
     //     Rectangle viereck = new Rectangle();
     //     Rectangle viereck1 = new Rectangle();
     //     Rectangle viereck2 = new Rectangle(21,11);
     //     Rectangle viereck3 = new Rectangle();
     //     
     //     
     //     Console.WriteLine($"Anzahl der Objekte ist: {GeometricObject.CountGeometricObjects}");
     //     
     //     Circle kreis = new Circle(21);
     //     Circle kreis1 = new Circle(16);
     //     Circle kreis2 = new Circle(15);
     //
     //     Console.WriteLine($"Anzahl der Objekte ist; {GeometricObject.CountGeometricObjects}");
     //
     //     IDraw[] arr = new IDraw[6];
     //     arr[0] = new GraphicCircle();
     //     arr[1] = new GraphicRectangle();
     //     arr[2] = new Auto();
     //     arr[3] = new GraphicCircle();
     //     arr[4] = new GraphicRectangle();
     //     arr[5] = new Auto();
     //     foreach (IDraw item in arr)
     //     {
     //         item.Draw();
     //     }
     //
            GeometricObject[] arr = new GeometricObject[4];
            arr[0] = new Circle(20);
            arr[1] = new Rectangle(15, 15);
            arr[2] = new Circle(22);
            arr[3] = new GraphicRectangle(1, 1);
            Array.Sort(arr, new GeometricObjectComparer());
            foreach (GeometricObject item in arr)
                Console.WriteLine(item.ToString());
           

            Console.ReadLine();


  //         if (kreis1.Bigger(kreis2) == -1)
  //             Console.WriteLine("kreis1 < kreis 2");
  //         else
  //             Console.WriteLine("kreis1 > kreis2");
  //         Console.ReadLine();
  //
  //         kreis.XCoordinate = -100;
  //         kreis.YCoordinate = 90;
  //         kreis.Move(120, -200);
  //
  //        
  //
  //         Console.WriteLine("Geben sie den Radius an");
  //         kreis.Radius = Convert.ToDouble(Console.ReadLine());
  //
  //         
  //         
  //
  //         Console.WriteLine($"Die Fläche beträgt {kreis.GetArea()}" );
  //         Console.WriteLine($"Der Umfang beträgt {kreis.GetPerimeter()}");
  //
  //         Console.ReadLine();
  //
  //         Console.WriteLine($"Geben sie die Länge des Vierecks an");
  //         viereck.Length = Convert.ToDouble(Console.ReadLine());
  //         Console.WriteLine($"Geben sie die Breite des Vierecks an");
  //         viereck.With = Convert.ToDouble(Console.ReadLine());
  //
  //         Console.WriteLine($"Der Umfang beträgt: {viereck.GetPerimeter()}");
  //         Console.WriteLine($"Die Fläche beträgt: {viereck.GetArea()}");
  //
  //         Console.ReadLine();
  //
  //        if (kreis != null)
  //        {
  //            Console.WriteLine("Das Objekt existiert nicht");
  //            kreis = new Circle();
  //        }
  //        else
  //        {
  //            Console.WriteLine("Das Objekt existiert");
  //            Console.ReadLine();
  //        }
        }
    }
}
