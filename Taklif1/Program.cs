namespace Taklif1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[ , ] arr = new int[10 , 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Enter number:");
                    arr[i , j] = Int32.Parse(Console.ReadLine());
                }
            }


            int x, y;
            int n = 0;
            int m = 0;
            Console.WriteLine("Enter number x to search:");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number y to search:");
            y = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (arr[j , i] == x)
                    {
                        n++;
                    }
                    if (arr[j , i] == y)
                    {
                        m++;
                    }
                }
            }

            Console.WriteLine("x count is :" + n.ToString());
            Console.WriteLine("y count is :" + m.ToString());
        }
    }
}