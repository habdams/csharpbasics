// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Enter one word at a time, enter q to quit and print");
bool userQuits = false;
StringBuilder userWords = new StringBuilder();

while (!userQuits)
{
    string word = Console.ReadLine();

    if (word == "q")
    {
        userQuits = true;
        Console.WriteLine("--- Program closed ---");
    }else if(word.Contains(" "))

    {
        Console.WriteLine("Input should not include spaces or more than one word\nTry adding a word");
        
    }
    else
    {
        userWords.Append( word + " ");
    }
}

Console.WriteLine(userWords);
