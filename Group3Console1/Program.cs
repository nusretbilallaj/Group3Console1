
//Console.WriteLine("Kolegji AAB!");
//Console.WriteLine("--------------");
//Console.Write("Rroga mesatare");
//Console.Write(" ");
//Console.WriteLine(700);
//Console.WriteLine(true);
//Console.WriteLine(false);

//string emri;
//emri = "Leron Berisha";
//Console.WriteLine($"Profesori: {emri}");
//emri = "Albin";
//Console.WriteLine($"Profesori: {emri}");

//int rroga;
//rroga = 700;
//Console.WriteLine($"Rroga e deklaruar:{rroga}");

//bool kushti;
//kushti = true;

//if (kushti==true)
//{
//    Console.WriteLine("Urime liberalizimi");
//}
//else
//{
//    Console.WriteLine("Vitin tjeter!");
//}
//Console.WriteLine("-------------------------");
int mosha;
mosha=20;
KalkuloNivelin(mosha);
//if (mosha<=6)
//{
//    Console.WriteLine("Parashkollor");
//}
//else if (mosha <= 18)
//{
//    Console.WriteLine("Shkolla e mesme");
//}
//else
//{
//    Console.WriteLine("Kolegj");
//}


mosha = 18;
KalkuloNivelin(mosha);
//if (mosha<=6)
//{
//    Console.WriteLine("Parashkollor");
//}
//else if(mosha<=18)
//{
//    Console.WriteLine("Shkolla e mesme");
//}
//else
//{
//    Console.WriteLine("Kolegji");
//}

void KalkuloNivelin(int m)
{
    if (m <= 6)
    {
        Console.WriteLine("Parashkollor");
    }
    else if (m <= 18)
    {
        Console.WriteLine("Shkolla e mesme");
    }
    else
    {
        Console.WriteLine("Kolegji");
    }
}

KalkuloNivelin(2);
Console.WriteLine("<<<<<<<<<");
var mosha2=10;
KalkuloNivelin(mosha2);
Console.WriteLine(">>>>>>>>>");
