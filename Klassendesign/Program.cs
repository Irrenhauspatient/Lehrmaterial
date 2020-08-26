using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendesign
{
    class Program
    {
        #region Klassendesign

        static void Main(string[] args)
        {
            Person peter = new Person();
            peter.Alter = 34;
            peter.Laufen();

            Person bettina = new Person();
            bettina.Alter = 29;
            bettina.Laufen();
        }


        #endregion

    }



}
