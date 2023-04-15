namespace Taklif2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num 2:");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("bmm is: " + BMM(a,b));
            Console.WriteLine("kmm is: " + KMM(a,b));

        }
        private static int BMM(int num1, int num2)
        {
            int r;
            int bmm = num1;
            while (num2 != 0)
            {
                r = bmm % num2;
                bmm = num2;
                num2 = r;
            }
            return bmm;
        }
        private static int KMM(int num1, int num2)
        {
            int x = num1;
            int y = num2;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            return (x * y) / num1;
        }
    }
}