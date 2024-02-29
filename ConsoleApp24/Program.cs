// See https://aka.ms/new-console-template for more information

Dictionary<string, int> data = new Dictionary<string, int>
{
    {"Peter", 24},
    {"Steve", 35},
    {"John", 22},
    {"Jerry", 31},
};

foreach (KeyValuePair<string, int> datum in data)
{
    if (datum.Value < 25)
    {
        Console.WriteLine($"{datum.Key} - {datum.Value}");
    }
}