using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class GraphicCircle : Circle
    {
        public GraphicCircle() : base(0, 0, 0) { }
        public GraphicCircle(double radius) : base(radius, 0, 0) { }
        public GraphicCircle(double radius, double x, double y) :base (radius,x,y)
        {
            Radius = radius;
            XCoordinate = x;
            YCoordinate = y;
            GeometricObjectadd();
        }

        public void Draw()
        {
            Console.WriteLine($"Der Kreis wird gezeichnet");
            
        }
    }
}
