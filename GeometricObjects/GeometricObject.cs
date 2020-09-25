using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public abstract class GeometricObject
    {

        public virtual double XCoordinate { get; set; }
        public virtual double YCoordinate { get; set; }
       
   
        public abstract double GetArea();       
        public abstract double GetPerimeter();
        public virtual double Bigger(GeometricObject obj)
        {
            if (obj == null || GetArea() > obj.GetArea()) return 1;
            if (GetArea() < obj.GetArea()) return -1;
            return 0;
        }

        public virtual void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }
   
          public static int CountGeometricObjects { get; protected set; }
   
          public void GeometricObjectadd()
          {
            CountGeometricObjects++;           
            
          }
    
     
        public static int Bigger(GeometricObject obj1, GeometricObject obj2)
        {
            if (obj1 == null && obj2 == null) return 0;
            if (obj1 == null) return -1;
            if (obj2 == null) return 1;
            if (obj1.GetArea() > obj2.GetArea()) return 1;
            if (obj1.GetArea() < obj2.GetArea()) return -1;
            return 0;
        }

      
    }
}

