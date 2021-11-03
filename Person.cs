using System;

public class Person
{
    public static int Count = 0;
    public Person()
    {
        Console.WriteLine(++Count);
    }
}