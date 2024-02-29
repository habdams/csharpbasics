// See https://aka.ms/new-console-template for more information
float radius;
float diameter;
float circumference;
float height = 5;

static int getChoice(){
  Console.Write($"Type 1 for radius, type 2 for diameter, type 3 for circumference: ");
  return int.Parse(Console.ReadLine());
}

static int getValues(string label){
    Console.Write($"{label}: ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

static void CalculateCylinderVolume(float height, float radius){
    Console.WriteLine($"{height}: height");
    float volume = (float) (Math.PI * Math.Pow(radius, 2) * height);
     Console.WriteLine($"{volume}cm3");
}

int userChoice = getChoice();

switch (userChoice)
{
    case 1:
        radius = getValues("radius");
        CalculateCylinderVolume(height, radius );
        break;
    case 2:
        diameter = getValues("diameter");
        radius = diameter/2;
        CalculateCylinderVolume(height, radius);
        break;
    case 3:
        circumference = getValues("circumference");
        radius = (float)(circumference / (2*Math.PI));
        Console.WriteLine("iner:" + radius);
        CalculateCylinderVolume(height, radius);
        break;

    default:
        Console.WriteLine("Wrong info, closing application");
        break;
}