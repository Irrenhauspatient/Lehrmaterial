using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GeometricObjects
{
  

    class GraphicCircle : Circle, IDraw
    {
        public GraphicCircle() : base(0, 0, 0) { }
        public GraphicCircle(int radius) : base(radius, 0, 0) { }
        public GraphicCircle(int radius, int x, int y) :base (radius,x,y)
        {
            Radius = radius;
            XCoordinate = x;
            YCoordinate = y;
            GeometricObjectadd();
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Der Kreis wird gezeichnet");
            
        }
    }
}
