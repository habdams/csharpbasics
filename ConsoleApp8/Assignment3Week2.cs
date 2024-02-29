// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give two values");
Console.Write("First value:");
int value1 = Int32.Parse(Console.ReadLine());
Console.Write("Second value:");
int value2 = Int32.Parse(Console.ReadLine());

if(value1 < value2){
    Console.WriteLine("Second is greater than First");
}else if(value1 > value2){
    Console.WriteLine("First is greater than Second");
} else if(value1 == value2){
    Console.WriteLine("They are equal");
}