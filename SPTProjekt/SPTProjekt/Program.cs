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
            /* //bod A
             int x1 = 2; 
             int y1 = 3;
             //bod B
             int x2 = 2;
             int y2 = 3;
             //bod C 
             int x3 = 1;
             int y3 = 1;*/
            Console.Write("Zadejte první souradnici bodu A: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Zadejte druhou souradnici bodu A: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Zadejte první souradnici bodu B: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Zadejte druhou souradnici bodu B: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("Zadejte první souradnici bodu C: ");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("Zadejte druhou souradnici bodu C: ");
            int y3 = int.Parse(Console.ReadLine());

            // dva body v sobe
            if ((((x1 == x2) && (y1 == y2))) ||
               (((x2 == x3) && (y2 == y3))) ||
               (((x1 == x3) && (y1 == y3))))
            {
                Console.WriteLine("NESESTROJITELNY TROJUHELNIK - minimalne dva body v jednom bode");
                goto label;
            }
            //body na jedne primce
            if ((y1 == y2 && y1 == y3) || (x1 == x2 && x1 == x3))
            {
                Console.WriteLine("NESESTROJITELNY TROJUHELNIK- vsechny body v jedne primce");
                goto label;
            }
            if ((x3 / (x2 - x1)) - (x1 / (x2 - x1)) == (y3 / (y2 - y1)) - (y1 / (y2 - y1)))
            {
                Console.WriteLine("NESESTROJITELNY TROJUHELNIK- vsechny body v jedne primce");
            }


            label:
            //obsah 

            //obvod*/
            Console.ReadKey();

        }
    }
}

