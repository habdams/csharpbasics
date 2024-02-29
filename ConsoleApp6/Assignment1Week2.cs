// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your age?");
int age = Int32.Parse(Console.ReadLine());

if(age < 18){
    Console.WriteLine("You are not an adult");
}else{
    Console.WriteLine("You are an adult");
}
