using System;

class Program
{
    struct Auto
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Auto(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }


    static void Main()
    {
        Console.CursorVisible = false;

        const int width = 20;
        const int heigth = 20;
        int l = 3;
        label:
        int x = width / 2;
        int y = heigth / 2;
        Auto Trabant = new Auto(0, y - 2);
        Auto Skoda = new Auto(0, y - 3);
        ConsoleKey klavesa = new ConsoleKey();
        char[,] Matice = new char[width, heigth];

        do
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine($"Životy: {l}");
            Console.SetCursorPosition(0, 2);

            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Matice[j, i] = '-';
                }
            }

            Matice[x, y] = 'o';
            Matice[Trabant.X, Trabant.Y] = 'x';
            Matice[Skoda.X, Skoda.Y] = 'x';

            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(Matice[j, i]);
                }
                Console.WriteLine();
            }
            if (y == 0)
            {
                break;
            }
            if (((Trabant.Y == y) && (Trabant.X == x))|| ((Skoda.Y == y) && (Skoda.X == x)))
            {
                l = --l;
                if (l != 0)
                {
                    goto label;
                }
                else
                {
                    break;
                }
            }
            if (Console.KeyAvailable)
            {
                klavesa = Console.ReadKey().Key;

                switch (klavesa)
                {
                    case ConsoleKey.LeftArrow:
                        if (!(x == 0))
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (!(x == width-1))
                        {
                            x++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (!(y == 0))
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (!(y == heigth-1))
                        {
                            y++;
                        }
                        break;
                    default:
                        break;
                }
            }
            Trabant.X = ++Trabant.X % width;
            Skoda.X = (Skoda.X+2) % width;
            System.Threading.Thread.Sleep(40);
        } while (klavesa != ConsoleKey.Escape);
        if (((Trabant.Y == y) && (Trabant.X == x)) || ((Skoda.Y == y) && (Skoda.X == x)))
        {
            Console.Clear();
            Console.Write("Game over");
        }
        else if(y==0)
        {
            Console.Clear();
            Console.Write("Vítězství");
        }
            System.Threading.Thread.Sleep(1500);
            Console.ReadKey();
    }
}