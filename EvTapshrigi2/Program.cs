



namespace EvTapshrigi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reverse = new ReverseNumber();

            Console.Write("Eded daxil edin : ");
            int number = int.Parse(Console.ReadLine());

            int reversenumber = reverse.Number(number);
            Console.WriteLine($"{number} => {reversenumber}");
        }
    }
}