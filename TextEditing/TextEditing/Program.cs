

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            char c = Console.ReadKey(true).KeyChar;
            Console.WriteLine(char.IsAscii(c));
        }
    }
}