namespace Sandbox_2;

class Program
{
    static void awesomeFunction(int x)
        {
            Console.WriteLine($"The argument is {x}.");
        }
    static void Main(string[] args)
    {
        Console.WriteLine("Howdy, Potato World!");
        for (int i = 1; i <= 10; i ++)
        {
        Console.WriteLine(i);
        }
        awesomeFunction(3);

    }
}
