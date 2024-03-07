// See https://aka.ms/new-console-template for more information

string str = "05/01/2008 8:30:52 AM";
string date = str.Substring(0,10);
string[] dateCol = date.Split("/");

string[] terms = {"day", "month", "year" };

Dictionary<string, string> dateDict = new Dictionary<string, string>()
{
    {terms[0], "" },
    {terms[1], ""},
    {terms[2], ""}
};

for (int i = 0; i < 3; i++)
{
    dateDict[terms[i]] = dateCol[i];
}


bool showSelection = true;

while (showSelection)
{
    Console.WriteLine("1 - Full date\n2 - Day\n3 - Month\n4 - Year");
    int userSelection = int.Parse(Console.ReadLine());
    
    if (userSelection > 4)
    {
        showSelection = false;
    }
    switch (userSelection)
    {
        case 1:
            Console.WriteLine(date);
            break;
        case 2:
            Console.WriteLine(dateDict[terms[userSelection-2]]);
            break;
        case 3:
            Console.WriteLine(dateDict[terms[userSelection-2]]);
            break;
        case 4:
            Console.WriteLine(dateDict[terms[userSelection-2]]);
            break;
        default:
            Console.WriteLine("");
            break;
    }
}


