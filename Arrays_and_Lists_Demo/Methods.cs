using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Lists_Demo
{
    internal class Methods
    {
        public static int[] CreateRandomArrayOfSize10()
        {
            int[] myArray = new int[10];
            var r = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = r.Next(1, 11);
                Console.WriteLine(myArray[i]);
            }
            return myArray;
        }
    }
}
