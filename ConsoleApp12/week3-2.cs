// See https://aka.ms/new-console-template for more information

static int getValues(string label){
    Console.WriteLine($"Enter {label}");
    int value = Int32.Parse(Console.ReadLine());
    return value;
}

static int CalculateArea(int width, int height){
    int area = width * height;
    return area;
}

int width = getValues("width");
int height = getValues("height");
int area = CalculateArea(width, height);

Console.WriteLine($"Area for width {width} and height {height} is {area}");