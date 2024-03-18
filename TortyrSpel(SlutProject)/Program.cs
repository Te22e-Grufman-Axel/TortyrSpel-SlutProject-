using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.IO;

int Nuveranderum = 6;

string[] contents = File.ReadAllLines(@"localfile.txt");
Console.WriteLine(contents[0]);
Console.ReadLine();




while (true)
{
    if (Nuveranderum == 0)
    {
        Console.Clear();
       Nuveranderum = Rum0568.Rum0(Nuveranderum);
    }
    else if (Nuveranderum == 1)
    {

    }
    else if (Nuveranderum == 2)
    {

    }
    else if (Nuveranderum == 3)
    {

    }
    else if (Nuveranderum == 4)
    {

    }
    else if (Nuveranderum == 5)
    {
        Console.Clear();
        (Nuveranderum) = Rum0568.Rum5(Nuveranderum);
    }
    else if (Nuveranderum == 6)
    {
        Console.Clear();
        Nuveranderum = Rum0568.Rum6(Nuveranderum);
    }
    else if (Nuveranderum == 7)
    {

    }
    else if (Nuveranderum == 8)
    {
        Console.Clear();
       Nuveranderum = Rum0568.Rum8(Nuveranderum);
    }
    else if (Nuveranderum == 9)
    {

    }
    else if (Nuveranderum == 10)
    {

    }
    else
    {
        Console.Clear();
        Console.WriteLine("WTF Har Du gjort");
        Console.WriteLine("Kontakta axel för att fixa");
        Console.ReadLine();
    }

}







Console.WriteLine("Du är i slutet");
Console.ReadLine();