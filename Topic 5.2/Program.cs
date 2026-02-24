namespace Topic_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade;
            string name;
            int age;

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
        }
    }
}
