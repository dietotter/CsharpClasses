using System;

// TASK 2 & TASK 5
public class User
{
    public int Id { get; }
    public int Age { get; }
    public string Name { get; }
    public string Surname { get; }

    public User(int id = 0, int age = 0, string name = "", string surname = "")
    {
        Id = id;
        Age = age;
        Name = name;
        Surname = surname;
    }

    public bool IsInfoPresent(string info)
    {
        if (Name.Equals(info) || Surname.Equals(info))
        {
            return true;
        }

        if (Int32.TryParse(info, out int parsedInt))
        {
            if (parsedInt == Id || parsedInt == Age)
            {
                return true;
            }
        }
        
        return false;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Surname: " + Surname);
    }
}

public class TestUser
{
    static void FindUser(string input, User[] users)
    {
        bool isUserPresent = false;

        foreach (User user in users)
        {
            if (user.IsInfoPresent(input))
            {
                isUserPresent = true;
                user.PrintInfo();
            }
        }

        if (!isUserPresent)
        {
            Console.WriteLine("Couldn't find a user with such information");
        }
    }

    public static void TestTask2()
    {
        User[] users = new User[] { new User(1, 18, "Shrek", "Shrekings"), new User(2, 23, "Fiona", "Princess"), new User(3, 50, "Donkey", "Johnson") };
        Console.WriteLine("Please, print your input to search users by: ");
        string input = Console.ReadLine();

        FindUser(input, users);
    }
}