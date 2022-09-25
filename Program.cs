
List<int> numbers = new List<int>();
int usernumber = -1;
while (usernumber != 0)
{
    Console.Write("Enter a number (0 to quit): ");
    string response = Console.ReadLine();
    usernumber = int.Parse(response);
    numbers.Add(usernumber);
}
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine($"The sum is: {sum}");

float average = ((float)sum) / numbers.Count;
Console.WriteLine($"The average is: {average}");

int max = numbers[0];

foreach (int number in numbers)
{
    if (number > max)
    {
        max = number;
    }
}
Console.WriteLine($"The max is: {max}");

Console.WriteLine("This is a list of all the numbers: ");
foreach (int coso in numbers)
{
    Console.WriteLine(coso);
}