using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //комментарий
            Console.WriteLine("C# from Metanit");
            //константа
            const string name = "Bob";
            //литералы
            Console.WriteLine(true);
            Console.WriteLine(505.5+0b11);
            Console.WriteLine('A');
            Console.WriteLine("hello\nword");
            var hello = "Hell to World";
            var c = 20;
            Console.WriteLine(hello);
            Console.WriteLine(c);
            //консольный ввод
            Console.WriteLine("что то");
            var t=Console.ReadLine();
            Console.WriteLine(t);
            //остаток от целочисленного деления
            double z = 10 % 4;
            Console.WriteLine(z);
            //логич умножение &
            Console.WriteLine(4 & 5);
            Console.WriteLine(2 & 5);
            //логич сложение |
            Console.WriteLine(2 | 5);
            Console.WriteLine(4 & 5);
            // ||
            Console.WriteLine((5 > 6) || (4 < 6));
            Console.WriteLine((5 > 6) || (4 > 6));
            // &&
            Console.WriteLine((5 > 6) && (4 < 6));
            Console.WriteLine((5 < 6) && (4 < 6));
            Console.WriteLine("a=");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b=");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            }
            else
            {
                Console.WriteLine($"Число {num1} равно числу {num2}");
            }
            //тернарная операция
            Console.WriteLine("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y=");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x < y ? (x + y) : (x - y));

            for (int i = 1; i < 4; i++) Console.WriteLine(i);
            int n = 6;
            do
            {
                Console.WriteLine(n);
                n--;
            }
            while (n > 0);

            foreach (char k in "Tom")
            {
                Console.WriteLine(k);
            }

            for (int i = 0; i < 9; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i * j} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}