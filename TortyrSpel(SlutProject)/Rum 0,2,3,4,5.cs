using System.Data.SqlTypes;

public class Rum02345
{
    public static int Rum0(int Nuveranderum)
    {

        Console.WriteLine("Welcome to my game");
        Console.WriteLine("My name is Maledictus BoB Grim");
        Console.WriteLine("What may your name be?");
        Console.WriteLine("Eeh, Dosen't matter, you will probobly soon be dead anyways");
        Console.WriteLine("you will go by the id nummber '0762-34656-5' from now on");

        Console.WriteLine("If you manage to survie my litle game");
        Console.WriteLine("You will be rewarded with fredome");
        Console.WriteLine("But if you dont, Well lets just hope you do");
        Console.WriteLine("Walk throue the door infront of you to start");

        Console.ReadKey();
        Nuveranderum = 1;
        return Nuveranderum;
    }
    public static int Rum2(int Nuveranderum)
    {
        Console.WriteLine("As you fall, you see that it's a labyrinth below you");
        Console.WriteLine("You hit the ground hard, but manage to stand up");
        Console.WriteLine("Lucky I landed softly you think");
        Console.WriteLine("Then you hear from speakers");
        Console.WriteLine("How's it going testSubject 0762-34656-5");
        Console.WriteLine("So far, all you done is a simpel test");
        Console.WriteLine("Now comes your first real test");
        Console.WriteLine("Escape from this labyrinth and you're one step closer to your freedom");

        Console.ReadKey();
        Maze.Main();

        Nuveranderum = 3;
        return Nuveranderum;
    }
    public static int Rum3(int Nuveranderum)
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
        Nuveranderum = 4;
        return Nuveranderum;
    }
    public static int Rum4(int Nuveranderum)
    {
        Console.WriteLine("As you enter the next room you see another screen infront of you");
        Console.WriteLine("You ask yourself why you got to answer more questions");
        Console.WriteLine("As a questions pops up on the screen and you move to answer it");
        Random random = new Random();
        for (int i = 0; i < 25; i++)
        {
            int QuestionsNumber = random.Next(100);
            string[] Questions = File.ReadAllLines(@"Questions.txt");
            string[] Answers = File.ReadAllLines(@"Answers.txt");
            string playerAnswer = "";
            Console.WriteLine(Questions[QuestionsNumber]);
            playerAnswer = Console.ReadLine().ToLower(); ;

            if (playerAnswer != Answers[QuestionsNumber].ToLower())
            {
                Death.ByQuiz();
            }
        }
        Nuveranderum = 5;
        return Nuveranderum;
    }
    public static int Rum5(int Nuveranderum)
    {
        Console.WriteLine("When you walk throue the door you see what looks like another maze on the other side");
        Console.WriteLine("You take a deep breath and think, do i really have to do another maze");
        Console.WriteLine("As you enter the maze a voice comes over the loduspeaker");
        Console.WriteLine("Welcome to  your second mase, This one is harder then the last");
        Console.WriteLine("But one thing you should know is that i left my pet in there");
        Console.WriteLine("Oops, lets just hope you dont run into him");

        Console.ReadKey();
        Maze.Main();
        Nuveranderum = 6;
        return Nuveranderum;
    }
}