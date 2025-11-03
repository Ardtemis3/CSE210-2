using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // string firstName;
        // string lastName;

        // Console.WriteLine("Please enter your first name: ");
        // firstName = Console.ReadLine();

        // Console.WriteLine("Please enter your last name: ");
        // lastName = Console.ReadLine();

        // Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}.");

        bool done = false;

        while (!done)
        {
            Console.WriteLine("Input your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 125)
            {
                done = true;
                Console.WriteLine($"Your age: {age}");
            }
        }
        done = false;
        // do while loops will always run atleast once
        do
        {
            Console.WriteLine("Input your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 125)
            {
                done = true;
                Console.WriteLine($"Your age: {age}");
            }
        } while (!done);
    }
}