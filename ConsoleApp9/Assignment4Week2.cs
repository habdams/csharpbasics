// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a character");
char input = Char.Parse(Console.ReadLine());

Console.WriteLine(input);

switch (input)
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine($"{input} is a vowel");
        break;
    default:
        Console.WriteLine($"{input} is a consonant");
        break;
}