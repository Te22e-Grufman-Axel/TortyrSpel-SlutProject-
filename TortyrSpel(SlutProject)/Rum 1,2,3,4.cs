public class Rum1234
{

    public static int Rum1(int Nuveranderum)
    {

        Console.ReadKey();
        Nuveranderum = 2;
        return Nuveranderum;
    }

    public static int Rum2(int Nuveranderum)
    {

        Console.ReadKey();
        Nuveranderum = 3;
        return Nuveranderum;
    }

    public static int Rum3(int Nuveranderum)
    {
        List<String> PlayerAnswers = new List<String>();
        PlayerAnswers.Add("Hej");
        PlayerAnswers.Add("Hur mår du?");

        PlayerAnswers.ToArray();
        File.WriteAllLines("SvarPerSonTest.txt", PlayerAnswers);



        Console.ReadKey();
        Nuveranderum = 4;
        return Nuveranderum;
    }

    public static int Rum4(int Nuveranderum)
    {

        Console.ReadKey();
        Nuveranderum = 5;
        return Nuveranderum;
    }
}