// See https://aka.ms/new-console-template for more information

string words ="The quick brown fox jumps over the lazy dog";

string[] wordS = words.Split(" ");

bool userQuit = false;

while (!userQuit)
{
    Console.WriteLine("Enter a letter to find in {0}", words);
    string? userLetter = Console.ReadLine();
    if (userLetter?.Length > 1)
    {
        userQuit = true;
        Console.WriteLine("End of program");

    }
    else
    {
        Console.WriteLine("Matching words");
        foreach (string word in wordS)
        {
           
        
            if (word.Contains(userLetter!))
            {
                Console.WriteLine(word);
            }
        }

    }

}
