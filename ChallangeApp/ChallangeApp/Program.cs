using System.Security.AccessControl;

string imie = "Marcin";
char plec = 'm';
int wiek = 40;

if (plec == 'm')
{
    if (wiek > 30)
    {
        Console.WriteLine("Mezczyzna powyzej 30 roku zycia");
    }
    else if (wiek > 40 && imie == "Marcin")
    {
        Console.WriteLine("Marcin po 40 :)");
    }

    else
    {
        Console.WriteLine("Inna osoba");
    }
}  