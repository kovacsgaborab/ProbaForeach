using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = 0;

            foreach (int t in tomb)
            {
                sum += t;
                Console.WriteLine(t.ToString());
            }

            Console.WriteLine("Az összegük: {0}", sum);

            Console.ReadKey();
        }
    }
}
