using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class GraphicRectangle : Rectangle
    {
        public GraphicRectangle() : base(0, 0, 0, 0) { }
        public GraphicRectangle(double length, double with) : base(length, with, 0, 0) { }
        public GraphicRectangle(double length, double with, double x, double y)
        {
            Length = length;
            With = with;
            XCoordinate = x;
            YCoordinate = y;
            GeometricObjectadd();
        }


        public void Draw()
        {
            Console.WriteLine($"Das Viereck wird gezeichnet");

        }
    }
}