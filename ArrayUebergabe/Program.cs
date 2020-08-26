using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUebergabe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 2, 3, 15, 33, 23, 120, 154, 17, 9,512, 36, 222 };
            Console.WriteLine($"Der Größte wert im Arrays beträgt: {GetMaxValue(test)}");
            Console.ReadLine();
        }

        static int GetMaxValue(int[] arr)
        {

            int maxValue = 0;
            foreach (int item in arr)
           
                if (item > maxValue)
                    maxValue = item;
                return maxValue;
                
            
        }
        
       
    }
}
