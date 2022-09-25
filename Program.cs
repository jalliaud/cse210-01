internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("what is your name?: ");
        string FirstName = Console.ReadLine();

        Console.Write("what is your last name?: ");
        string LastName = Console.ReadLine();

        Console.WriteLine($"My name is {LastName}, {FirstName} {LastName}");
    }
}