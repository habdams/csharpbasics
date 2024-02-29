// See https://aka.ms/new-console-template for more information
List<int> myNumbers = new List<int> { };
int evenTotal = 0;
Console.WriteLine("Enter 10 integers");

for (int i = 0; i < 10; i++)
{
    int number = int.Parse(Console.ReadLine());
    myNumbers.Add(number);
}

foreach (int number in myNumbers)
{
    if (number % 2 == 0)
    {
        evenTotal += number;
    }
}

Console.WriteLine($"Total: {evenTotal}");