

namespace FBc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your 'Fizz' Number:");
            string fizzy = Console.ReadLine();
            int f = int.Parse(fizzy);
            Console.WriteLine("Your 'Fizz' number is " + f + "!");

            Console.WriteLine("Enter your 'Buzz' Number:");
            string buzzy = Console.ReadLine();
            int b = int.Parse(buzzy);
            Console.WriteLine("Your 'Buzz' number is " + b + "!");

            int fb = f * b;
            Console.WriteLine("Your 'FizzBuzz' number is " + fb + "!");

            Console.WriteLine("What number should we count to?");
            string limit = Console.ReadLine();
            int l = int.Parse(limit);
            Console.WriteLine("Your 'Limit' number is " + l + "!");


            Console.WriteLine("What is your 'Fizz' phrase?");
            string fizzName = Console.ReadLine();
            Console.WriteLine("Your 'Fizz' phrase is " + fizzName + "!");

            Console.WriteLine("What is your 'Buzz' phrase?");
            string buzzName = Console.ReadLine();
            Console.WriteLine("Your 'Buzz' phrase is " + buzzName + "!");


            string fizzbuzzName = fizzName + "-" + buzzName;
            Console.WriteLine("Your 'FizzBuzz' phrase is " + fizzbuzzName + "!");

            for (int i = 0; i <= l; i++)
            {
                if (i % fb == 0)
                { Console.WriteLine(fizzbuzzName); }
                else

                if (i % b == 0)
                { Console.WriteLine(buzzName); }
                else

                if (i % f == 0)
                { Console.WriteLine(fizzName); }
                else

                    Console.WriteLine("          " + i);
            }
            Console.WriteLine("(version 1 - copyright 2018 JUGGERNOTT81)");
            Console.WriteLine("(version 2 - copyright 2022 JUGGERNOTT81)");
            Console.ReadLine();
        }
    }
}