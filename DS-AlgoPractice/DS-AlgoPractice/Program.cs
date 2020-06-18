using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_AlgoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = {1, 2, 3, 9, 8, 7};
            TrapWater trapWater = new TrapWater();
            int trappedWater = trapWater.Trap(height);
            Console.WriteLine(trappedWater);
            Console.ReadKey();
        }
    }
}
