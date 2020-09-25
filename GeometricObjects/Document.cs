using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GeometricObjects
{
 
    class Document : ICopy, IAdress
    {

        void ICopy.Copy()
        {
            Console.WriteLine("Copy Methode in ICopy");
        }

        void IAdress.Copy()
        {
            Console.WriteLine("Copy Methode in IAdress");
        }
        public void Copy()
        {
            Console.WriteLine("Das Dokument wird kopiert");
        }

        public int Compare(object obj)
        {
            throw new NotImplementedException();
        }

        private string _Caption;

        public string Caption
        {
            get { return _Caption; }
            set { _Caption = value; }
        }


       

        
        
    }


}
