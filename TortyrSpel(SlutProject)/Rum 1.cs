public class Rum_1
{

    public static int Rum1(int Nuveranderum)
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
        Console.WriteLine("As you walk closer you see a question pop upp");
        Console.WriteLine("");

        Console.WriteLine("What is you name?");
        answer = Console.ReadLine();
        PlayerAnswers.Add(answer);

        Console.WriteLine("What is your age?");
        string TmpAnswer = Console.ReadLine();
        bool success = int.TryParse(TmpAnswer, out nummer);
        if (success == false)
        {
            Console.WriteLine("That was not a nummber!");
            Console.ReadKey();
        }
        PlayerAnswers.Add(nummer.ToString());

        while (!HasAnswered)
        {
            Console.WriteLine("What is your id nummber?");
            answer = Console.ReadLine();
            if (answer == "0762-34656-5")
            {
                PlayerAnswers.Add(answer);
                HasAnswered = true;
            }
            else
            {
                Console.WriteLine("Wrong, Try again");
            }
        }
        HasAnswered = false;
        Console.WriteLine("Answer all the next questions on a scale of 1-10");
        Console.WriteLine("Where 1 is the lowest and 10 the higest");
        string[] QuestionsPersonTest = File.ReadAllLines(@"QuestionsPersonTest.txt");
        for (int i = 0; i < QuestionsPersonTest.Length-99; i++)
        {
            int question = i;
            PlayerAnswers = personaletytestMCQ(PlayerAnswers, question);
        }
        string path = @"SvarPerSonTest.txt";
        File.WriteAllLines(path, PlayerAnswers.ToArray());
        Console.WriteLine("As you answer the last question a trapdoor open beneath you");
        Console.ReadKey();
        Nuveranderum = 2;
        return Nuveranderum;
    }
    static public List<string> personaletytestMCQ(List<string> PlayerAnswers, int question)
    {
        int nummer = 0;
        string[] QuestionsPersonTest = File.ReadAllLines(@"QuestionsPersonTest.txt");
        bool hasNotAnswerd = true;
        Console.WriteLine(QuestionsPersonTest[question]);
        while (hasNotAnswerd)
        {
            string TmpAnswer = Console.ReadLine();
            bool success = int.TryParse(TmpAnswer, out nummer);
            if (success == false)
            {
                Console.WriteLine("That was not a nummber!");
                Console.WriteLine("Answer again");
            }
            else if(success == true)
            {
                hasNotAnswerd = false;
            }
        }
        if (nummer > 10 || 10 > 0)
        {
            PlayerAnswers.Add(nummer.ToString());
        }
        else
        {
            Console.WriteLine("That was not between 1-10");
        }
        return PlayerAnswers;
    }
}