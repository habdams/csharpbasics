// See https://aka.ms/new-console-template for more information


static int getSelection(){
    int selection = int.Parse(Console.ReadLine());
    Console.WriteLine($"You selected: {selection}");

    return selection;
}

int selection = getSelection();
int result = 0;

while(selection > 0 && selection <= 3){
    result = result + selection*2;
    Console.WriteLine($"Result is: {result}");
    selection = getSelection();
}

