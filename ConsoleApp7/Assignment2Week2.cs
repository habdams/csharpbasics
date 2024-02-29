// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your birthyear?");
int year = Int32.Parse(Console.ReadLine());

int currentAge = 2024 - year;

if(currentAge >= 18 && currentAge <= 65){
    Console.WriteLine("You are within working age");
}else{
    Console.WriteLine("You are not within working age");
}
