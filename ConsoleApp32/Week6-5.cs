// See https://aka.ms/new-console-template for more information

static string ReverseSentence(string sentence)
{
    List<char> charArray = new List<char>();

    foreach (char character in sentence)
    {
        charArray.Add(character);
    }

    charArray.Reverse();
    string newReverseString = String.Join("", charArray);

    return newReverseString;
};

string sentence = "The quick brown fox";

Console.WriteLine(ReverseSentence(sentence));
