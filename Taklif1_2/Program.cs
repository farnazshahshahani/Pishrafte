namespace Taklif1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter number:");
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
        }
    }
}