using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public interface ICopy
    {      
       
        string Caption { get; set; }
        void Copy();
       
    }
}
