using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GeometricObjects
{
    class Auto : IDraw
    {
        public virtual void Draw()
        {
            Console.WriteLine("Das Auto wird gezeichnet");
        }
    }
}
