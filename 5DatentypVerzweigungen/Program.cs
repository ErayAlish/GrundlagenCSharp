using System;

//Aufgabe 1


Console.WriteLine("Biite geben Sie die erste Zahl ein:");
string Zahl1 = Console.ReadLine();
Console.WriteLine("bitte geben Sie die zweite Zahl ein:");
string Zahl2 = Console.ReadLine();

int Zahlint1 = Convert.ToInt32(Zahl1);
int Zahlint2 = Convert.ToInt32(Zahl2);

if (Zahlint1 > Zahlint2)
{
    Console.WriteLine(Zahlint2);
}

if (Zahlint1 < Zahlint2)
{
    Console.WriteLine(Zahlint1);
}

//Aufgabe 2

string eing;
int geraten;
int geheim;
int versuche = 0;
Random zufall = new Random();
geheim = zufall.Next(101);
do
{
    Console.Write("Zahl eingeben (0-1000): ");
    eing = Console.ReadLine() 0;
    geraten = Convert.ToInt32(eing);

    if (geraten < geheim)
    {
        Console.WriteLine("Eingabe zu klein");
    }
    if (geraten > geheim)
    {
        Console.WriteLine("Eingabe zu groß");
    }
    versuche = versuche + 1;
} while (geraten != geheim && versuche < 6);

if (geraten == geheim)
{
    Console.WriteLine("Super! Du hast nur " + versuche
    + " Versuche benötigt");
}
else
{
    Console.WriteLine("Verloren es wäre " + geheim
        + " gewesen!");
}
Console.ReadKey();
//Aufgabe 3


Console.WriteLine("Sind Sie Übergewichtet Bitte beantworten Sie mit true oder false");
bool Antwort1 = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Haben Sie Stress?");
bool stress = Convert.ToBoolean(Console.ReadLine());
Console.Clear();
Console.WriteLine("Die Hertzinfarktrisiko beträgt bei:");
if (stress == false && Antwort1 == false)
    Console.WriteLine("5%");
else if (stress == false && Antwort1 == true)
    Console.WriteLine("18%");
else if (stress == true && Antwort1 == false)
    Console.WriteLine("15%");
else if (stress == true && Antwort1 == true)
    Console.WriteLine("62%");


//Aufgabe 4  


Console.WriteLine("Bitte geben Sie die erste Zahl ein :_");
string zahl01 = Console.ReadLine();
Console.WriteLine("Bitte gebén Sie die zweite Zahl ein :_");
string zahl02 = Console.ReadLine();

Console.Clear();
Console.WriteLine("Was möchten sie berechnen");
Console.WriteLine(@"
1 Addition 
2 Subtraktion 
3 Multiplikation
4 Division
5 Potenz
");
string was01 = Console.ReadLine();
