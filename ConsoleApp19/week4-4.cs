// See https://aka.ms/new-console-template for more information
Random rand = new Random();
float sum = 0;
float baseNum = 100000;
float from0to25 = 0;
float from25to50 = 0;
float from50to75 = 0;
float from75to100 = 0;

// get sum of averages
for(int i = 0; i < baseNum; i++){
    int randomValue = rand.Next(0, 101);
    sum += randomValue;
}

// calculate for average
float average = sum/baseNum;
Console.WriteLine($"Average is: {average}");

// categorize random value into range
for(int i = 0; i < baseNum; i++){
    int randomValue = rand.Next(0, 101);

    if(randomValue <= average * 0.25){
        from0to25++;
    }else if( randomValue <= average * 0.5){
        from25to50++;
    }else if(randomValue <= average * 0.75){
        from50to75++;
    }else{
        from75to100++;
    }
}

//convert to percentages
float c1 = (from0to25 / baseNum )* 100;
float c2 = (from25to50 / baseNum) * 100;
float c3 = (from50to75 / baseNum) * 100;
float c4 = (from75to100 / baseNum) * 100;

//display result
Console.WriteLine($"0-25: {c1}%");
Console.WriteLine($"25-50: {c2}%");
Console.WriteLine($"50-75: {c3}%");
Console.WriteLine($"75-100: {c4}% {from75to100}");