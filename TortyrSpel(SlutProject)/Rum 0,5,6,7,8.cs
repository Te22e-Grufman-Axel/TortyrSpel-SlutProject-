using System.Data.SqlTypes;

public class Rum05678
{
    public static int Rum0(int Nuveranderum)
    {
        Console.WriteLine("Welcome to my game");
        Console.WriteLine("My name is Maledictus BoB Grim");
        Console.WriteLine("What may your name be?");
        Console.WriteLine("Eeh, Dosent matter, you will probobly soon be dead anyways");

        Console.WriteLine("If you manage to survie my littel game");
        Console.WriteLine("You will be rewarded with fredome");
        Console.WriteLine("But if you dont, Well lets just hope you do");
        Console.WriteLine("Walk throue the door infront of you to start");

        Console.ReadKey();
        Nuveranderum = 5;
        return Nuveranderum;
    }
    public static int Rum5(int Nuveranderum)
    {
        Console.WriteLine("A hole opens beneath you and you fall down");
        Console.WriteLine("As you fall, you see that it's a labyrinth below you");
        Console.WriteLine("You hit the ground hard, but manage to stand up");
        Console.WriteLine("Lucky I landed softly you think");
        Console.WriteLine("Then you hear from speakers");
        Console.WriteLine("How's it going testSubject 0762-34656-5");
        Console.WriteLine("So far, you've fought against robots and solved puzzles");
        Console.WriteLine("Now comes your first real test");
        Console.WriteLine("Escape from this labyrinth and you're one step closer to your freedom");

        Console.ReadKey();
        Maze.Main();

        Nuveranderum = 6;
        return Nuveranderum;
    }
    public static int Rum6(int Nuveranderum)
    {
        Console.WriteLine("Right as you get out of the mase you see a parcour course infront of you");
        Console.WriteLine("As you hear over the speaker");
        Console.WriteLine("You did good testsubject 0762-34656-5");
        Console.WriteLine("Not alot of peopel come this far");
        Console.WriteLine("Lets see if your parcour skills are as good as your problem solving skills");
        Console.WriteLine("As you think to yourself, This guy is a jerk");
        Console.WriteLine("Lets see what i can do here");

        Random random = new Random();

        if (random.Next(100) < 30)
        {
            Death.ByParcour();
        }
        else
        {
            Console.WriteLine("you do your best and manage to get across");
            Console.WriteLine("When you are on the other side you hear over the speaker");
            Console.WriteLine("Good job TestSubject 0762-34656-5");
            Console.WriteLine("You made it");
            Console.WriteLine("Plese walk throue the door infront of you to procced");

        }
        Console.ReadLine();
        Nuveranderum = 7;
        return Nuveranderum;
    }
    public static int Rum7(int Nuveranderum)
    {
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            int QuestionsNumber = random.Next(100);
            string[] Questions = File.ReadAllLines(@"Questions.txt");
            string[] Answers = File.ReadAllLines(@"Answers.txt");
            string playerAnswer = "";
            // Console.WriteLine(QuestionsNumber);
            Console.WriteLine(Questions[QuestionsNumber]);
            // Console.WriteLine(Answers[QuestionsNumber]);
            playerAnswer = Console.ReadLine().ToLower(); ;

            if (playerAnswer != Answers[QuestionsNumber].ToLower())
            {
                Death.ByQuiz();
            }
        }
        Nuveranderum = 8;
        return Nuveranderum;
    }
    public static int Rum8(int Nuveranderum)
    {
        Console.WriteLine("When you walk throue the door you see what looks like another maze on the other side");
        Console.WriteLine("You take a deep breath and think, do i really have to do another maze");
        Console.WriteLine("As you enter the maze a voice comes over the loduspeaker");
        Console.WriteLine("Welcome to  your second mase, This one is harder then the last");
        Console.WriteLine("But one thing you should know is that i left my pet in there");
        Console.WriteLine("Oops, lets just hope you dont run into him");

        Console.ReadKey();
        Maze.Main();
        return Nuveranderum;
    }
}