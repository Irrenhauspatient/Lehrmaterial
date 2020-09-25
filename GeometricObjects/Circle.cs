using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GeometricObjects
{
    public class Circle : GeometricObject
    {
        #region Konstruktoren
        public Circle() : this(0, 0, 0) { }
        public Circle(int radius) : this(radius, 0, 0) { }
        public Circle(int radius, int x, int y)
        {
            Radius = radius;
            XCoordinate = x;
            YCoordinate = y;
            GeometricObjectadd();
        }

        #endregion

        public override int XCoordinate { get; set; }
        public override int YCoordinate { get; set; }

        #region Eigenschaften


        private int _Radius;

        public int Radius
        {
            get { return _Radius; }
            set
            {

                if (value >= 0)

                {
                    _Radius = value;
                }

                else
                {
                    Console.WriteLine("Ungültige eingabe versuchen sie es erneut");
                    Console.ReadLine();

                }
            }
        }
        #endregion
        public override double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
      

        public override double GetPerimeter()
        {
            return 2 * Radius * Math.PI;
        }

        public override string ToString()
        {
            return "Circle, R=" + Radius + ",Fläche=" + GetArea()
        }
    }
}
