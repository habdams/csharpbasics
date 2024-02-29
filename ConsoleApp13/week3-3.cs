// See https://aka.ms/new-console-template for more information

static int RequestValue(){
    int value =  int.Parse(Console.ReadLine());
    return value;
}

static bool IsEven(int value){
    return value % 2 == 0 ? true : false;
}

static void PrintResult(bool even, int value){
    string outcome = even ? "even" : "odd";

    Console.WriteLine($"{value} is {outcome}");
}

int value = RequestValue();
bool even = IsEven(value);
PrintResult(even, value);
value = RequestValue();
even = IsEven(value);
PrintResult(even, value);
value = RequestValue();
even = IsEven(value);
PrintResult(even, value);