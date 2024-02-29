// See https://aka.ms/new-console-template for more information

static int getValues(string label){
    Console.Write($"Give {label} ");
    int value = Int32.Parse(Console.ReadLine());
    return value;
}


static void CalculateCylinderVolume(int height, int radius){
    float volume = (float) (Math.PI * Math.Pow(radius, 2) * height);

     Console.WriteLine($"{volume}cm3");
}


int height = getValues("height");
int radius = getValues("radius");

CalculateCylinderVolume(height,radius);