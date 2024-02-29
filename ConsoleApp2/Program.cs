// See https://aka.ms/new-console-template for more information

List<string> names = new List<string>();

while (names.Count <= 5)
{
    Console.WriteLine("Give a name or type q to quit");
    string answer = Console.ReadLine();

    if (names.Contains(answer))
    {
        Console.WriteLine($"{answer} already exists");
    }
    else if(answer == "q")
    {
        Console.WriteLine("Quiting Program");
        break;
    }
    else
    {
        names.Add(answer);
    }
}

names.Sort();

foreach (string name in names)
{
    Console.WriteLine(name);
}


