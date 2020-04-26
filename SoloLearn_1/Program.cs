using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = { 10, 15, 88, 465 };
            int sum = 0;
            foreach (int x in b)
            {
                sum += x;
            
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            
        }
    }
}
