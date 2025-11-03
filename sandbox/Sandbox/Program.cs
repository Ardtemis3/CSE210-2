using System;

class Program
{
    static void TestValues(int x, float y, double z)
    {
        Console.WriteLine($"The values are: {x}, {y}, {z}.");
    }
    static void Main(string[] args)
    {
        // ----------------------------------------------------------------------------------------------------------------
        // Console.WriteLine("Hello Sandbox World!");
        // string firstName;
        // string lastName;

        // Console.WriteLine("Please enter your first name: ");
        // firstName = Console.ReadLine();

        // Console.WriteLine("Please enter your last name: ");
        // lastName = Console.ReadLine();

        // Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}.");

        // bool done = false;
        // ----------------------------------------------------------------------------------------------------------------
        // while (!done)
        // {
        //     Console.WriteLine("Input your age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine($"Your age: {age}");
        //     }
        // }
        // done = false;
        // // do while loops will always run atleast once
        // do
        // {
        //     Console.WriteLine("Input your age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine($"Your age: {age}");
        //     }
        // } while (!done);

        // ----------------------------------------------------------------------------------------------------------------

        // List<int> numbers = new List<int>();
        // numbers.Add(10);
        // numbers.Add(2234);
        // numbers.Add(-234);
        // numbers.Add(101);
        // foreach (int n in numbers)
        // {
        //     Console.WriteLine($"The number is {n}.");
        // }

        // ----------------------------------------------------------------------------------------------------------------

        // TestValues(10, (float)123.234, 789456132.4745123516114);
    }
}