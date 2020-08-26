using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Rectangle : GeometricObject
    {
        
        #region Konstruktoren
        public Rectangle() : this(0, 0, 0, 0) { }
        public Rectangle(double length, double with) : this(length,with, 0, 0) { }
        public Rectangle(double length,double with, double x, double y)
        {
            Length = length;
            With = with;
            XCoordinate = x;
            YCoordinate = y;
            Rectangle.CountGeometricObjects++;
        }

        #endregion

        public override double XCoordinate { get; set; }
        public override double YCoordinate { get; set; }

        #region Eigenschaften


        private double _Length;

        public double Length
        {
            get { return _Length; }
            set
            {

                if (value >= 0)

                {
                    _Length = value;
                }

                else
                {
                    Console.WriteLine("Ungültige eingabe versuchen sie es erneut");
                    Console.ReadLine();

                }
            }
        }

        private double _With;

        public double With
        {
            get { return _With; }
            set
            {

                if (value >= 0)

                {
                    _With = value;
                }

                else
                {
                    Console.WriteLine("Ungültige eingabe versuchen sie es erneut");
                    Console.ReadLine();

                }
            }
        }
        #endregion

        #region Methoden
        public override double GetArea()
        {
            return With * Length;
        }


        public override double GetPerimeter()
        {
            return 2 * With + 2 * Length;
        }
        #endregion
    }


}

    

