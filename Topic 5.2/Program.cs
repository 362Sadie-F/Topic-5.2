namespace Topic_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade;
            string name;

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
        }
    }
}
