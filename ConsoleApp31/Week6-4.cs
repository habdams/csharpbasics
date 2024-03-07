// See https://aka.ms/new-console-template for more information

static string ProcessSentence(string sentence)
{
    foreach (char character in sentence)
    {
        if (Char.IsDigit(character))
        {
            int digitIndex = sentence.IndexOf(character);
            string processedString = sentence.Substring(0, digitIndex + 1);
            return processedString.ToUpper();
        }
    }

    return "hello";
};

string sentence = "Welcome to week 6 of this C# course";

string ans = ProcessSentence(sentence);

Console.WriteLine(ans);