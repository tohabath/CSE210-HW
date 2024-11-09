public class Stretching : Activity {
    //ATTR

    //METH
    public void RunStretching()
    {
        int totalTime = Intro("Welcome to the stretching activity!\n\nThis activity will get you out of your chair, so you can get some feeling back into your legs! You can also do some stretches, if you so please.");
        System.Console.WriteLine("Get ready...");
        PlayAnimation(5);
        Console.Clear();
        System.Console.WriteLine("Now, stand up...");
        PlayAnimation(3);
        Console.Clear();
        System.Console.Write("And STREEE");
        while (totalTime > 0)
        {
            System.Console.Write("E");
            Thread.Sleep(1000);
            totalTime = totalTime - 1;
        }
        System.Console.Write("ETCH!");
        Thread.Sleep(3000);
        System.Console.Write("\n\n.");
        Thread.Sleep(1000);
        System.Console.Write(".");
        Thread.Sleep(1000);
        System.Console.Write(".");
        Thread.Sleep(3000);
        System.Console.WriteLine("\n\nOh hey, we're done!");
        Thread.Sleep(3000);
        GetName("stretching");
        EndMessage();
    }
}