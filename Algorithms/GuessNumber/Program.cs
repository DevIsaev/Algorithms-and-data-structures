namespace GuessNumber
{
    class Programm
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tmp;
            int max = 0;
            int min = 0;
            int tryCount = 0;
            int gameCount= 0;
            do
            {
                gameCount++;
                var rand = new Random().Next(1, 101);
                int number = rand;
                int attemptCount = 0;
                //Console.WriteLine(number);

                while (true)
                {
                    attemptCount++;
                    tryCount++;
                    Console.WriteLine("Enter you try in [1;100]");
                    int tries = 0;
                    while (!int.TryParse(Console.ReadLine(), out tries) || tries < 1 || tries > 100)
                    {
                        Console.WriteLine("Error. Enter correct number in [1;100]");
                    }
                    if (tries > number)
                    {
                        Console.WriteLine("Your try is more");
                    }
                    else if (tries < number)
                    {
                        Console.WriteLine("Your try is less");
                    }
                    else
                    {
                        Console.WriteLine("You win");
                        break;
                    }
                }
                tryCount += attemptCount;
                if (max<attemptCount) { 
                    max=attemptCount;
                }
                min=min==0||min>attemptCount? attemptCount: min;
                Console.WriteLine("Enter y if you want to play again");
                tmp = Console.ReadKey();
            }
            while (tmp.Key==ConsoleKey.Y);
            Console.WriteLine($"Min = {min}\nMax={max}\nAvg={(double)tryCount/gameCount}");
        }
    }
}