// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// int[,] array =  { { 10, 10, 10, 10, 10 }, { 9, 0, 435, 67, 34 }, {1,2,3,4,5} };
// foreach (int tempInt in array)
//     {
//         Console.WriteLine(tempInt);
//     };

Dictionary<string, string> stat = new Dictionary<string, string>{
    {"name", "Oyinkan"},
    {"DOB", "21Feb2021"}
};

foreach(KeyValuePair<string, string> item in stat){
    Console.WriteLine($"{item.Key}: {item.Value}");
}