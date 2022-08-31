
// Aufgabe 1 
short short_max = short.MaxValue;
short short_min = short.MinValue;
Console.WriteLine(short_max);
Console.WriteLine(short_min);
/*
 * 32767
-32768
*/

Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);
/*
 * 2147483647
-2147483648
*/

Console.WriteLine(long.MaxValue);
Console.WriteLine(long.MinValue);
/*
 * 9223372036854775807
-9223372036854775808
*/



// Aufgabe 2
var vorname = "Eray";
var age = "17";
var answer = "no";
Console.WriteLine(vorname);
Console.WriteLine(age);
Console.WriteLine(answer);


// Aufgabe 3
int DollarZahl = 36;
char Dollar = (char)DollarZahl;

Console.WriteLine(DollarZahl);

// Aufgabe 4 
string eingabe = Console.ReadLine();
short short_number = Convert.ToInt16(eingabe);

Console.WriteLine(short_number / 10);

String eingabe2 = Console.ReadLine();
double double_number = Convert.ToDouble(eingabe2);

