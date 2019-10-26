using System;

namespace Lab_02_6program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.Write("Write number from 1 to 100: ");
                byte N = Byte.Parse(Console.ReadLine());
                if (N != 0)
                {
                    if (N % 10 == 0 || N > 4 && N < 20 || N % 10 == 5 || N % 10 == 6 || N % 10 == 7 || N % 10 == 8 || N % 10 == 9)
                    {
                        Console.WriteLine($"{N} лет");
                    }
                    else if (N == 1 || N % 10 == 1)
                    {
                        Console.WriteLine($"{N} год");
                    }
                    else if (N % 10 != 0 || N % 10 != 1)
                    {
                        Console.WriteLine($"{N} года");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Write number isn't equal zero, please");
                    Console.ReadKey();
                    Program.Main(args);
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error.. Try again");
                Console.ReadKey();
                Program.Main(args);
            }
        }
    }
}
