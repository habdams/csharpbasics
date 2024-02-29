// See https://aka.ms/new-console-template for more information

string username = "Adetunji";
string password = "JAMK";
int attempt = 0;
bool ok = false;

do{
    Console.Write("Enter your username: ");
    string Iusername = Console.ReadLine();
    Console.Write("Enter your password: ");
    string Ipassword = Console.ReadLine();

    if(Iusername.Equals(username) && Ipassword.Equals(password)){
        ok = true;
        Console.WriteLine("Successful Login");
    }else{
        Console.WriteLine("Wrong Credentials");
        attempt++;
        ok = false;
    }
    if(attempt == 3){
        Console.WriteLine("Wrong credentials 3 times, closing application");
    }
}while(!ok && attempt < 3);
