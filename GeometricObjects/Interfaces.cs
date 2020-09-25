using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public interface IDraw
    {
        void Draw();
    }
    interface ICompare
    {
        int Compare(Object obj);
    }

    interface ICopy : ICompare
    {
        string Caption { get; set; }
        void Copy();
    }

    public interface IAdress
    {
        void Copy();
    }

}
