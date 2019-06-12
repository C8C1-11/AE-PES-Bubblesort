using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teronis.Tools.NetStandard;

namespace AE_PES_Bubblesort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 5, 2, 4, 3 };
            IListTools.Bubblesort(array);

            foreach (var number in array)
                Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
