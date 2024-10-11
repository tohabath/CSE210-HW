using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new();
        p1._firstName = "Mary";
        p1._lastName = "Smith";
        p1._age = 25;

        Person p2 = new();
        p2._firstName = "John";
        p2._lastName = "Watkins";
        p2._age = 30;
        List<Person> people = new();
        people.Add(p1);
        people.Add(p2);

        foreach (Person p in people)
        {
            System.Console.WriteLine(p._firstName);
        }
        SaveToFile(people);
        List<Person> newPeople = ReadFromFile();
        foreach (Person p in newPeople)
        {
            System.Console.WriteLine($"{p._lastName}");
        }
    }
    public static void SaveToFile(List<Person> people)
    {
        System.Console.WriteLine("Saving to file...");
        string filename = "people.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine($"{p._firstName}~~{p._lastName}~~{p._age}");
            }
        }
        System.Console.WriteLine("Finished.");
    }
    public static List<Person> ReadFromFile()
    {
        System.Console.WriteLine("Reading from file...");
        List<Person> people = new();
        string filename = "people.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            // System.Console.WriteLine(line);
            string[] parts = line.Split("~~");
            Person newPerson = new();
            newPerson._firstName = parts[0];
            newPerson._lastName = parts[1];
            newPerson._age = int.Parse(parts[2]);

            people.Add(newPerson);
        }
        return people;
    }
}