using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GeometricObjects
{
    public abstract class GeometricObject : IComparable
    {

        public virtual int XCoordinate { get; set; }
        public virtual int YCoordinate { get; set; }
       
   
        public abstract double GetArea();       
        public abstract double GetPerimeter();
        public virtual int Bigger(GeometricObject obj)
        {
            if (obj == null || GetArea() > obj.GetArea()) return 1;
            if (GetArea() < obj.GetArea()) return -1;
            return 0;
        }

        public virtual void Move(int dx, int dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }
   
          public static int CountGeometricObjects { get; protected set; }
   
          public void GeometricObjectadd()
          {
            CountGeometricObjects++;           
            
          }
    
     
 //     public static int Bigger(GeometricObject obj1, GeometricObject obj2)
 //     {
 //         if (obj1 == null && obj2 == null) return 0;
 //         if (obj1 == null) return -1;
 //         if (obj2 == null) return 1;
 //         if (obj1.GetArea() > obj2.GetArea()) return 1;
 //         if (obj1.GetArea() < obj2.GetArea()) return -1;
 //         return 0;
 //     }

        public virtual int CompareTo(object obj)
        {
            GeometricObject geoObject = obj as GeometricObject;
            if(geoObject != null)
            {
                if (GetArea() < geoObject.GetArea()) return -1;
                if (GetArea() == geoObject.GetArea()) return 0;
                return 1;
            }
            throw new ArgumentException("Es wird der Typ GeometricObject erwartet.");
        }
    }
}

