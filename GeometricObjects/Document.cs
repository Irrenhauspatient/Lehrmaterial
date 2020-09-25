using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Document : ICopy
    {
        public void Copy()
        {
            Console.WriteLine($"Das Dokument wird kopiert";
        }
        private string _Caption;

        public string Caption
        {
            get { return _Caption; }
            set { _Caption = value; }
        }

    }
}
