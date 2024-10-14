namespace TimeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new(1, 10, 15);
            Duration D2 = new(3600);
            Duration D3 = new(7800);
            Duration D4 = new(666);

            Console.WriteLine(D1.PrintDuration());
            Console.WriteLine(D2.PrintDuration());
            Console.WriteLine(D3.PrintDuration());
            Console.WriteLine(D4.PrintDuration());


        }
    }
}
