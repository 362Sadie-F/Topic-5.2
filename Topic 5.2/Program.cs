using System.ComponentModel.Design;

namespace Topic_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade;
            double bet;
            string name;
            int age;
            int betNum;

            Console.WriteLine("What was your lowest grade last semester?");
            grade = Convert.ToDouble(Console.ReadLine());
            if (grade >=50)
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
            if (age <=16)
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
            if (int.TryParse(Console.ReadLine(), out betNum));
            {
                Console.WriteLine("You bet " + betNum.ToString("C"));
            }
            else
            {
                Console.WriteLine("Invalid number");
                Console.WriteLine("Your bet is set to the minumum of 1.00$");
                betNum = 1;
            }
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
        }
        }
    }

