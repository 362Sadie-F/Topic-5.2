using System.ComponentModel.Design;

namespace Topic_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade;
            double water;
            string name;
            string number;
            int age;
            int bet;

            Console.WriteLine("What was your lowest grade last semester?");
            grade = Convert.ToDouble(Console.ReadLine());
            if (grade >= 50)
            {
                Console.WriteLine("Great! You passed!");
            }
            else
            {
                Console.WriteLine("Uh oh- Better luck next year!");
            }
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You're planning to drive? How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            if (age <= 16)
            {
                Console.WriteLine("Keep off the roads!");
            }
            else
            {
                Console.WriteLine("Be safe out there!");
            }
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("How much will you bet?");
            if (int.TryParse(Console.ReadLine(), out bet))
            {
                Console.WriteLine("You bet " + bet.ToString("C"));
            }
            else
            {
                Console.WriteLine("Invalid number");
                Console.WriteLine("Your bet is set to the minumum of 1.00$");
                bet = 1;
            }
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Please enter your grade: ");
            grade = Convert.ToDouble(Console.ReadLine());
            if (grade < 50)
            {
                Console.WriteLine("Uh oh.. this is an F grade, better luck next time.");
            }
            else if (grade <= 65)
            {
                Console.WriteLine("This is a D grade");
            }
            else if (grade <= 75)
            {
                Console.WriteLine("This is a C grade");
            }
            else if (grade <= 85)
            {
                Console.WriteLine("This is a B grade!");
            }
            else
            {
                Console.WriteLine("Wow! This is an A grade! Great job!");
            }
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //Multiple choice
            Console.WriteLine("Which number is even?");
            Console.WriteLine("\t Five, Seven, Four, Nineteen \t");
            number = Console.ReadLine();
            if (number == "Five")
            {
                Console.WriteLine("Incorrect! The answer is Four.");
            }
            else if (number == "five")
            {
                Console.WriteLine("Incorrect! The answer is Four.");
            }
            else if (number == "Seven")
            {
                Console.WriteLine("Incorrect! The answer is Four.");
            }
            else if (number == "seven")
            {
                Console.WriteLine("Incorrect! The answer is Four.");
            }
            else if (number == "Four")
            {
                Console.WriteLine("Correct!");
            }
            else if (number == "four")
            {
                Console.WriteLine("Correct!");
            }
            else if (number == "Nineteen")
            {
                Console.WriteLine("Incorrect! The answer is Four.");
            }
            else if (number == "nineteen")
            {
                Console.WriteLine("Incorrect! The answer is Four.");
            }
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //Water
            Console.Write("What Celcius temperature is your water? ");
            water = Convert.ToDouble(Console.ReadLine());
            if (water <= 0)
            {
                Console.WriteLine("Your water is Ice!");
            }
            else if (water >= 100)
            {
                Console.WriteLine("Your water is Steam!");
            }
            else if (water < 100)
            {
                Console.WriteLine("Your water is Water!");
            }
            else if (water > 0)
            {
                Console.WriteLine("Your water is Water!");
            }
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //How old are you
           Console.Write("Wondering what you can/can't do? Enter your name and age here: ");
            name = Console.ReadLine(); 
            age = Convert.ToInt32(Console.ReadLine());
            


            
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

