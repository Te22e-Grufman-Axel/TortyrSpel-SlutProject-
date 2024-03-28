using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.IO;

int Nuveranderum = 0;




while (true)
{
    if (Nuveranderum == 0)
    {
        Console.Clear();
       Nuveranderum = Rum02345.Rum0(Nuveranderum);
    }
    else if (Nuveranderum == 1)
    {
        Console.Clear();
       Nuveranderum = Rum_1.Rum1(Nuveranderum);
    }
    else if (Nuveranderum == 2)
    {
        Console.Clear();
       Nuveranderum = Rum02345.Rum2(Nuveranderum);
    }
    else if (Nuveranderum == 3)
    {
        Console.Clear();
       Nuveranderum = Rum02345.Rum3(Nuveranderum);
    }
    else if (Nuveranderum == 4)
    {
        Console.Clear();
       Nuveranderum = Rum02345.Rum4(Nuveranderum);
    }
    else if (Nuveranderum == 5)
    {
        Console.Clear();
        (Nuveranderum) = Rum02345.Rum5(Nuveranderum);
    }
    else if (Nuveranderum == 6)
    {
        Console.Clear();
        Nuveranderum = Rum_6.Rum6(Nuveranderum);
    }
    else
    {
        Console.Clear();
        Console.WriteLine("WTF Har Du gjort");
        Console.WriteLine("Kontakta Axel för att fixa");
        Console.ReadLine();
    }

}







Console.WriteLine("Du är i slutet");
Console.ReadLine();