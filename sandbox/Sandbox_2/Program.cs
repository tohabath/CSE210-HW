namespace Sandbox_2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Smellow, world");

        Bin myBin = new("quarters", 0.25, 40);

        myBin.ModifyQuantity(+6);
        System.Console.WriteLine(myBin.CountValue());

        


    }
}
