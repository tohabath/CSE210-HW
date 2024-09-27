using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int correctAnswer = randomGenerator.Next(1, 101);
        int guess;
        int attempts = 0;
        string guessString;
        Console.WriteLine($"What is the magic number? {correctAnswer}");
        do
        {
            Console.Write("What is your guess? ");
            guessString = Console.ReadLine();
            guess = int.Parse(guessString);
            if (guess > correctAnswer)
            {
                Console.WriteLine("Lower");
                attempts += 1;
            } 
            else if (guess < correctAnswer)
            {
                Console.WriteLine("Higher");
                attempts += 1;
            } 
            else 
            {
                Console.WriteLine("Correct!");
                attempts += 1;
                Console.WriteLine($"Total attempts: {attempts}");
            }
        } while (guess != correctAnswer);

    }
}