using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GeometricObjects
{
    public class Rectangle : GeometricObject
    {
        
        #region Konstruktoren
        public Rectangle() : this(0, 0, 0, 0) { }
        public Rectangle(int length, int with) : this(length,with, 0, 0) { }
        public Rectangle(int length,int with, int x, int y)
        {
            Length = length;
            With = with;
            XCoordinate = x;
            YCoordinate = y;
            GeometricObjectadd();
        }

        #endregion

        public override int XCoordinate { get; set; }
        public override int YCoordinate { get; set; }

        #region Eigenschaften


        private int _Length;

        public int Length
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

        private int _With;

        public int With
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

    

