using System;

namespace RandomizerConsole
{
    class Program
    {

        public void theApp()
        {

            Random rnd = new Random();
            Program program = new Program();

            Console.WriteLine("WELCOME TO RANDOMIZER CONSOLE");

            Console.Write("First Choice: ");
            string firstChoice = Console.ReadLine();

            Console.Write("Second Choice: ");
            string secondChoice = Console.ReadLine();

            Console.Write("Third Choice: ");
            string thirdChoice = Console.ReadLine();

            int randomChoice = rnd.Next(1, 4);

            if (randomChoice == 1)
            {

                Console.WriteLine("Random Choice is " + firstChoice);
            }

            else if (randomChoice == 2)
            {

                Console.WriteLine("Random Choice is " + secondChoice);
            }

            else
            {

                Console.WriteLine("Random Choice is " + thirdChoice);
            }

            Console.Write("PRESS ENTER TO RESTART");
            Console.ReadLine();
            program.theApp();   
            


        }

        static void Main(string[] args)
        {

            Program program = new Program();

            Console.WriteLine("PRESS ENTER TO START");
            program.theApp();


        }
    }
}
