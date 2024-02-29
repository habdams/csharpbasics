// See https://aka.ms/new-console-template for more information

Random rand = new Random();
float sum = 0;
float baseNum = 100000;

for(int i = 0; i < baseNum; i++){
    int randomValue = rand.Next(0, 101);
    sum += randomValue;
}

Console.WriteLine($"Average is: {sum/baseNum}");