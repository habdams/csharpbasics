// See https://aka.ms/new-console-template for more information
Console.Write("Enter Temperature in Fahrenheit:");

double tempF = Double.Parse(Console.ReadLine());

double tempC =  (tempF - 32) * 5/9;

Console.WriteLine($"{tempF}f degree Fahrenheit is {tempC}c degree Celsius");

if(tempC < 0){
    Console.WriteLine("Freezing");
}else{
    Console.WriteLine("Not Freezing");
}