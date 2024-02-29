// See https://aka.ms/new-console-template for more information

static int getSelection(){
    int selection = int.Parse(Console.ReadLine());
    Console.WriteLine($"You selected: {selection}");

    return selection;
}

int result = 0;
bool validEntry = true;
int selection = getSelection();


do{
    
    result = result + selection*2;
    Console.WriteLine($"Result is: {result}");
    selection = getSelection();
        if(selection < 0 || selection > 3){
        validEntry = false;
    }
    Console.WriteLine(validEntry);
}while(validEntry);
