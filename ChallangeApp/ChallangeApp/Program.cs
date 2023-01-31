int[] grades = new int[5];
List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedzialek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("sroda");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piatek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");
//Console.WriteLine(dayOfWeeks[2]);

//string[] dayOfWeeks2 = { "poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela" };
//Console.WriteLine(dayOfWeeks2[0]);
//
//for (var i = 0; i < dayOfWeeks.Count; i++)
foreach (var day in dayOfWeeks)
{
    Console.WriteLine(day);
}
