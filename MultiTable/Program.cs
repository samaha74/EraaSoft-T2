namespace MultiTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x , i = 1;
            char c = 'Y';
            while (c == 'Y')
            {
                Console.Write("Enter Your Num: ");
                x = Convert.ToInt32(Console.ReadLine());
                while (i < 13)
                {
                    Console.WriteLine($"{x} * {i} = {x * i}");
                    i++;
                }
                i = 1;
                Console.WriteLine("Again?(Y/N) ");
                c = Convert.ToChar(Console.ReadLine().ToUpper());
            }
        }
    }
}
