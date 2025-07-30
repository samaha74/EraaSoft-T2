namespace GradeChecker
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int g;
            while (true)
            { 
                Console.Write("Enter your mark (0-100):");
                g = Convert.ToInt32(Console.ReadLine());
                if (g >= 0 && g <= 100)
                    break;
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }

            if (g >= 90)
                Console.WriteLine("Your grade is A");
            else if (g >= 80)
                Console.WriteLine("Your grade is B");
            else if (g >= 70)
                Console.WriteLine("Your grade is C");
            else if (g >= 60)
                Console.WriteLine("Your grade is D");
            else
                Console.WriteLine("YOU FAILED");

        }
    }
}
