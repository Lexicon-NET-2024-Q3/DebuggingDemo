
namespace DebuggingDemo2024Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            //foreach (var item in args)
            //{
            //    Console.WriteLine(item);
            //}

            int result = GetSum(a, b);
            Console.WriteLine(result);

            Console.WriteLine("Hello, World!");            

            int res2 = 0;

            for (int i = 0; i < 100; i++)
            {
                res2 = i;
            }

            Console.ReadKey();

        }

        private static int GetSum(int a, int b)
        {
            return a + b;
        }
    }
}
