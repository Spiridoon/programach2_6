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
                Console.Write("Write number from 1 to 100(10000): ");
                short N = Int16.Parse(Console.ReadLine());
                if (N != 0)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        if (i % 10 == 0 || i % 10 > 4 && i % 10 <= 9 || i % 100 > 10 && i % 100 < 20)
                        {
                            Console.WriteLine($"{i} лет");
                        }
                        else if (i == 1 || i % 10 == 1)
                        {
                            Console.WriteLine($"{i} год");
                        }
                        else if (i % 10 != 0 || i % 10 != 1)
                        {
                            Console.WriteLine($"{i} года");
                        }
                    }
                    Console.ReadKey();
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
