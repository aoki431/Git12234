internal class Program
{
    private static void Main(string[] args)
    {
        {
            int x;
            Console.WriteLine("Число: \n");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"y = {Math.Sqrt(x) + 10*2}");
        }
    }
}
