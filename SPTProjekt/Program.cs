using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trojuhelnik
{
    /// <summary>
    /// Trida Program ma na zaklade vstupu uzivatele overit, zda-li je trojuhelnik sestrojitelny z bodu, ktere zadal.
    /// Program overuje, jestli body nejsou v jedne primce, nejsou body v sobě, nebo jestli jsou vyhovujici delky stran.
    /// </summary>
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
            bool par = false;

            int x1 = new int();
            while (par == false)
            {
            Console.Write("Zadejte první souradnici bodu A: ");
            par = int.TryParse(Console.ReadLine(),out x1);
            }

            par = false;
            int y1 = new int();
            while (par == false)
            {
            Console.Write("Zadejte druhou souradnici bodu A: ");
            par = int.TryParse(Console.ReadLine(),out y1);
            }

            par = false;
            int x2 = new int();
            while (par == false)
            {
            Console.Write("Zadejte první souradnici bodu B: ");
            par = int.TryParse(Console.ReadLine(),out x2);
            }

            par = false;
            int y2 = new int();
            while (par == false)
            {
            Console.Write("Zadejte druhou souradnici bodu B: ");
            par = int.TryParse(Console.ReadLine(),out y2);
            }

            par = false;
            int x3 = new int();
            while (par == false)
            {
            Console.Write("Zadejte první souradnici bodu C: ");
            par = int.TryParse(Console.ReadLine(),out x3);
            }

            par = false;
            int y3 = new int();
            while (par == false)
            {
            Console.Write("Zadejte druhou souradnici bodu C: ");
            par = int.TryParse(Console.ReadLine(),out y3);
            }


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
            


            /*if ((((y1 == y2) && (y3 != y1)) || ((y1 == y3) && (y2 != y1)) || ((y2 == y3) && (y1 != y2))) && (((x1 == x2) && (x3 != x1)) || ((x1 == x3) && (x2 != x1)) || ((x2 == x3) && (x1 != x2))))
            {
                goto label;
            }
            */
            if (!(x2==x1||y2==y1))
            {
                if ((x3 / (x2 - x1)) - (x1 / (x2 - x1)) == (y3 / (y2 - y1)) - (y1 / (y2 - y1)))
                {
                    Console.WriteLine("NESESTROJITELNY TROJUHELNIK- vsechny body v jedne primce");
                }
            }
            


            label:
            //delky stran 
            double ab = new double();
            double bc = new double();
            double ca = new double();
            ab = Math.Pow((Math.Abs(x1 - x2)), 2) + Math.Pow((Math.Abs(y1 - y2)), 2);
            ab = Math.Sqrt(ab);
            bc = Math.Pow((Math.Abs(x2 - x3)), 2) + Math.Pow((Math.Abs(y2 - y3)), 2);
            bc = Math.Sqrt(bc);
            ca = Math.Pow((Math.Abs(x3 - x1)), 2) + Math.Pow((Math.Abs(y3 - y1)), 2);
            ca = Math.Sqrt(ca);

           
            Console.WriteLine($"c={ab} a={bc} b={ca}");
            //věta SSS
            if ((ab + bc > ca) && (ca + bc > ab) && (ca + ab > bc))
            {
                Console.WriteLine("Trojuhelnik lze sestrojit");
            }
            else
            {
                Console.WriteLine("Trojuhelnik NELZE setrojit");
            }

            //obvod
            double o = ab + bc + ca;
            Console.WriteLine("Obvod = {0}", o);
            //obsah - heronův vzorec
            double so = o / 2;
            double S = Math.Sqrt(so * (so - ab) * (so - bc) * (so - ca));
            Console.WriteLine("Obsah = {0}", S);
            //pravouhlost
            if( ( Math.Round( (ab*ab) + (bc*bc),8)== Math.Round(ca*ca)) || ( Math.Round( (ca * ca) + (bc * bc),8)== Math.Round(ab * ab,8)) || ( Math.Round( (ca * ca) + (ab * ab),8)== Math.Round(bc * bc,8)))
                {
                Console.WriteLine("Trojuhelnik JE PRAVOUHLY");
                }
            else
            {
                Console.WriteLine("Trojuhelnik NENI PRAVOUHLY");
            }

            Console.ReadKey();

        }
    }
}

