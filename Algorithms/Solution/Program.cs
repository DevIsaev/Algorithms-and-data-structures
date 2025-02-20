using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = SumOfDigitsOfNumbers(1, 100);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        //метод возвращения суммы четных цифр чисел в промежутке от 1 до 100
        static int SumOfDigitsOfNumbers(int left, int right)
        {
            int summa = 0;
            for (int number = left; number <= right; number++)
            {
                int temp = Math.Abs(number);
                while (temp > 0)
                {
                    if (temp % 2 == 0)
                    {
                        summa += temp % 10;
                    }
                    temp /= 10;
                }
            } 

            return summa;
        }
    }
}