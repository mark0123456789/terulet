using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terület
{
    internal class Program
    {
        static void terulet() 
        {
            Console.WriteLine("Téglalap területének számítása");

            int a;
            int b;
            int T;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            T = a * b;
        }
        static void Main(string[] args)
        {
            terulet();
        }
    }
}
