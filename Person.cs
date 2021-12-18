using System;

// TASK 1 & TASK 4
public class Person
{
    public int Id { get; }
    public int Age { get; }
    public string Name { get; }
    public string Surname { get; }
    public static int Count = 0;
    public Person(int id = 0, int age = 21, string name = "Named", string surname = "Personality")
    {
        Id = id;
        Age = age;
        Name = name;
        Surname = surname;
        
        Console.WriteLine(++Count);
    }

    public Person(int id, int age)
    {
        Id = id;
        Age = age;
        Name = "Johnsons";
        Surname = "Baby";

        Console.WriteLine(++Count);
    }

    public Person(string name, string surname)
    {
        Id = 1;
        Age = 18;
        Name = name;
        Surname = surname;

        Console.WriteLine(++Count);
    }

    
}