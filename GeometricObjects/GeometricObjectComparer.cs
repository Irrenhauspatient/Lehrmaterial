using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GeometricObjects
{
    public class GeometricObjectComparer: IComparer
    {
        public virtual int Compare(object x, object y)
        {
            GeometricObject geo1 = x as GeometricObject;
            GeometricObject geo2 = y as GeometricObject;
            if (geo1 != null && geo2 != null)
                return geo1.Bigger(geo2);
            else
                throw new InvalidCastException();
        }
    }
}
