using System;

class Magic
{
    static void Main(string[] args)
    {
        int magicNumber;
        int guessNumber = -1;
        int count = 0;
        // Console.WriteLine("What is the magic number: ");
        // magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerate = new Random();
        magicNumber = randomGenerate.Next(1, 101);
        while (guessNumber != magicNumber)
        {
            Console.WriteLine("What is your guess: ");
            guessNumber = int.Parse(Console.ReadLine());
            count++;
            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine($"You got it in {count} tries.");
    }
}