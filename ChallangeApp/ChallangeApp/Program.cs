﻿int number = 84977;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char znak in letters)
{
    if(znak == '0')
    { 
        counter0++;
    }
    else if (znak == '1')
    {
        counter1++;
    }
    else if (znak == '2')
    {
        counter2++;
    }
    else if (znak == '3')
    { 
        counter3++;
    }
    else if (znak == '4')
    {
        counter4++;
    }
    else if (znak == '5')
    {
        counter5++;
    }
    else if(znak == '6')
    {
        counter6++;
    }
    else if(znak == '7')
    {
        counter7++;
    }
    else if(znak == '8')
    {
        counter8++;
    }
    else if(znak == '9')
    {
        counter9++;
    }
}
Console.WriteLine($"Skladowa liczby {number} to:");
Console.WriteLine($"0 jest {counter0}");
Console.WriteLine($"1 jest {counter1}");
Console.WriteLine($"2 jest {counter2}");
Console.WriteLine($"3 jest {counter3}");
Console.WriteLine($"4 jest {counter4}");
Console.WriteLine($"5 jest {counter5}");
Console.WriteLine($"6 jest {counter6}");
Console.WriteLine($"7 jest {counter7}");
Console.WriteLine($"8 jest {counter8}");
Console.WriteLine($"9 jest {counter9}");

Console.WriteLine($"0 jest {counter0}");