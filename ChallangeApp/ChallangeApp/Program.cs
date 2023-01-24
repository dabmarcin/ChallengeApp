using System.Security.AccessControl;

string imie = "Marcin";
char plec = 'm';
int wiek = 40;

if (plec == 'm')
{
    if (wiek > 50)
    {
        Console.WriteLine("Mezczyzna powyzej 50 roku zycia");
    }
    else if (wiek > 38 && imie == "Marcin")
    {
        Console.WriteLine("Facet! Po 40 robi sie goraco! ale nie boj nic... Marciny dadza rade :)");
    }
}
 else 
{
    Console.WriteLine("Inna osoba!");
}
   