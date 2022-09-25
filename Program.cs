
Random randomGenerator = new Random();
int number = randomGenerator.Next(0, 100);

int guess = -1;
while (guess != number)
{
    Console.Write("What is the magic number?(between 0-100): ");
    guess = int.Parse(Console.ReadLine()); 
    if (guess > number)
    {
        Console.WriteLine("lower");
    }
    else if (guess < number)
    {
        Console.WriteLine("higher");
    }
    else 
    {
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"The right number was {number}");
    }
}

