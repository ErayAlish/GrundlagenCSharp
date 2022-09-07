using System;

//Aufgabe 

//Console.WriteLine("Biite geben Sie die erste Zahl ein:");
//string Zahl1 = Console.ReadLine();
//Console.WriteLine("bitte geben Sie die zweite Zahl ein:");
//string Zahl2 = Console.ReadLine();

//int Zahlint1 = Convert.ToInt32(Zahl1);
//int Zahlint2 = Convert.ToInt32(Zahl2);

//if (Zahlint1 > Zahlint2)
//{
//    Console.WriteLine(Zahlint2);
//}
 
//if (Zahlint1 < Zahlint2)
//{
//    Console.WriteLine(Zahlint1);
//}


// Aufgabe 2

Console.WriteLine("Bitte geben Sie ein Zahl Zwischen 0-1000");
string Zahl01 = Console.ReadLine();
short Zahl;

Zahl = 500;

if (Zahl01 < 500)
{
    Console.WriteLine("Sie sind zu tief");
}

else {
    if (Zahl01 > 500)
{

        Console.WriteLine("Sie sind zu hoch");

    }
}