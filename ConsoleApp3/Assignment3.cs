// See https://aka.ms/new-console-template for more information
string name = "Adetunji";
string surname = "Ojekunle";
int age = 29;
string country = "Nigeria";
string hometown = "Abeokuta";
string favouriteColor = "Blue";
bool likesRockMusic = true;

/*
    I learnt here while running the solution after hitting an error that ternary operation cannot happen in an interpolation as ":" terminates the interpolation.
*/

Console.WriteLine("-------------------");
Console.WriteLine("Personal Data");
Console.WriteLine("-------------------");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Surname: {surname}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Country: {country}");
Console.WriteLine($"Hometown: {hometown}");
Console.WriteLine($"Favourite Color: {favouriteColor}");
Console.WriteLine($"Is it true you like Rock Music: it's {likesRockMusic}");