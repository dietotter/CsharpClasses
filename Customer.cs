using System;

// TASK 6
public class Customer
{
    public int Age { get; }
    public int CardNumber { get; }
    public int OrderSum { get; set; }
    public string Name { get; }
    public string Surname { get; }

    public Customer(int age = 0, int cardNumber = 0, int orderSum = 0, string name = "", string surname = "")
    {
        Age = age;
        CardNumber = cardNumber;
        OrderSum = orderSum;
        Name = name;
        Surname = surname;
    }

    public void ApplyDiscount(int percentage)
    {
        OrderSum -= OrderSum / 100 * percentage;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Card Number: " + CardNumber);
        Console.WriteLine("Order Sum: " + OrderSum);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Surname: " + Surname);
    }
}