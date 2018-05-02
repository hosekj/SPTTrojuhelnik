using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            //bod A
            int x1 = 2; 
            int y1 = 3;
            //bod B
            int x2 = 2;
            int y2 = 3;
            //bod C 
            int x3 = 1;
            int y3 = 1;
            // dva body v sobe
            if ((((x1 == x2) && (y1 == y2))) ||
               (((x2 == x3) && (y2 == y3))) ||
               (((x1 == x3) && (y1 == y3))))
            {
                Console.WriteLine("dva body v jednom bode");
            }
            //body na jedne primce 

            //obsah 

            //obvod
            Console.ReadKey();
            
        }
    }
}
