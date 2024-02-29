// See https://aka.ms/new-console-template for more information

Random random = new Random();

Dictionary<int, int> numberMap = new Dictionary<int, int>{};

for (int i = 0; i <= 100; i++)
{
    int value = random.Next(1,11);

    if (numberMap.ContainsKey(value))
    {
        numberMap[value] += 1;
    }
    else
    {
        numberMap.Add(value, 0);
    }
}

foreach (KeyValuePair<int, int> number in numberMap)
{
    Console.WriteLine($"Number: {number.Key} was generated {number.Value} times");
}