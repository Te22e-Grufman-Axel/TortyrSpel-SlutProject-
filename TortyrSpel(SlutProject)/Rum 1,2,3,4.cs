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
        string answer = "";
        int nummer = 0;
        bool HasAnswered = false;
        List<String> PlayerAnswers = new List<String>();
        Console.WriteLine("As you enter the next room, you hear over the loudspeaker");
        Console.WriteLine("In this test i will decide your personalety");
        Console.WriteLine("If you answer wrong, You die");
        Console.WriteLine("Good luck!");
        Console.WriteLine("");
        Console.WriteLine("As you start to look around you se a big screen light upp");
        Console.WriteLine("As you walk closer you see a answer pop upp");
        Console.WriteLine("");

        Console.WriteLine("What is you name?");
        answer = Console.ReadLine();
        PlayerAnswers.Add(answer);

        Console.WriteLine("What is your age?");
        // answer = Console.ReadLine();
        string TmpAnswer = Console.ReadLine();
        bool success = int.TryParse(TmpAnswer, out nummer);
        if (success == false)
        {
            Console.WriteLine("Det där var inte en siffra!");
            Console.ReadKey();
        }
        PlayerAnswers.Add(nummer.ToString());

        while (!HasAnswered)
        {
            Console.WriteLine("Answer this question on a scale of 1-10");
            Console.WriteLine("Where 1 is the lowest and 10 the higest");
            Console.WriteLine("How much do you like ice Cream");
            TmpAnswer = Console.ReadLine();
            success = int.TryParse(TmpAnswer, out nummer);
            if (success == false)
            {
                Console.WriteLine("Det där var inte en siffra!");
                Console.ReadKey();
            }
            if (nummer > 10 || 10 > 0)
            {
                PlayerAnswers.Add(nummer.ToString());
            }
            else
            {
                Console.WriteLine("Det där var inte mellan 1-10");
            }
            HasAnswered = true;
        }
    HasAnswered = false;
    
        string path = @"SvarPerSonTest.txt";
        File.WriteAllLines(path, PlayerAnswers.ToArray());
        // string readText = File.ReadAllText(path);
        // Console.WriteLine(readText);





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