// See https://aka.ms/new-console-template for more information


int[] numbers = new int[10];

for (int i = 0; i <= numbers.Length-1; i++)
{
    Random rand = new Random();
    int value = rand.Next();
    numbers[i] = value;
}

Array.Sort(numbers);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}