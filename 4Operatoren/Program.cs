using System;

//Aufgabe 1 


{
    string a = "Hallo";
    string b = "H";
    b += "allo";

    Console.WriteLine(b);
    // Hallo

    Console.WriteLine(b.Length);
    //5

    Console.WriteLine(a == b);
    //True

    Console.WriteLine((object)a == b);
    //False
}



//Aufgabe 2


{
    double x = 2.0;
    double y = x * x + 1 + x / 4;
    Console.WriteLine(y);

    /*
    Erwartetes Ergebnis
            5,5
    Nach der Kompilierung/Überprüfung
            5,5 
    */

}

{
    double x = 2.0;
    double y = x * (x + 1 + x / 4);
    Console.WriteLine(y);

    /*
     Erwartetes Ergebnis
         7
     Nach der Kompilierung/Überprüfung
         7
    */

}

{
    bool b = true && false || 5 > 6;
    Console.WriteLine(b);

    /*
    Erwartetes Ergebnis
            False
    Nach der Kompilierung/Überprüfung 
            False
    */

}

{
    int z = 50;
    bool numeric = z > 47 && z < 58;
    Console.WriteLine(numeric);

    /*
   Erwartetes Ergebnis
           True
   Nach der Kompilierung/Überprüfung 
           True
   */

}
