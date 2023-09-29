using System;

namespace threegames
{
    internal class Program
    {
        static Random rd = new Random();
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Выберите одно из трёх приложений");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Угадай число | 2. Таблица умножения | 3. Вывод делителей числа");
                Console.WriteLine("4. Закрыть");
                
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        one();
                        break;
                    case "2":
                        two();
                        break;
                    case "3":
                        three();
                        break;
                    case "4":
                        return;
                }
            }
        }

        static void one()
        {
            int rnum = rd.Next(1, 100);
            while (true)
            {
                Console.WriteLine("Число: ");
                int gnum = Convert.ToInt32(Console.ReadLine());
                if (gnum < rnum)
                {
                    Console.WriteLine("Число должно быть больше!");
                }
                else if (gnum == rnum)
                {
                    Console.WriteLine("Вы выйграли! То число было: "+gnum);
                    break;
                }
                else if (gnum > rnum)
                {
                    Console.WriteLine("Число должно быть меньше!");
                }
            }
        }

        static void two()
        {
            int[,] table = new int[10, 10];
            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                {
                    table[i, j] = i * j;
                }
            }

            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        static void three()
        {
            Console.WriteLine("Число: "); 
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + "\t");
                }
            }
        }
    }
}