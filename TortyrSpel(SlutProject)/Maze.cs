public class Maze
{
    static int mazeWidth = 42;
    static int mazeHeight = 22;
    static char[,] maze;

    static int playerX = 1;
    static int playerY = 1;

    public static void Main(string[] args)
    {
        GenerateMaze();


        while (true)
        {
            int newX = playerX;
            int newY = playerY;
            Console.Clear();
            // DrawMaze();
            if (maze[playerY - 1, playerX] != '#')
            {
                Console.WriteLine("You hava a door infront of you");
            }
            if (maze[playerY + 1, playerX] != '#')
            {
                Console.WriteLine("You hava a door behind you");
            }
            if (maze[playerY, playerX - 1] != '#')
            {
                Console.WriteLine("You hava a door to the left");
            }
            if (maze[playerY, playerX + 1] != '#')
            {
                Console.WriteLine("You hava a door to the right");
            }

            if (maze[playerY - 1, playerX] != '#')
            {
                Console.WriteLine("Write 'W' to go upp");
            }
            if (maze[playerY + 1, playerX] != '#')
            {
                Console.WriteLine("Write 's' to go down");
            }
            if (maze[playerY, playerX - 1] != '#')
            {
                Console.WriteLine("Write 'A' to go left");
            }
            if (maze[playerY, playerX + 1] != '#')
            {
                Console.WriteLine("Write 'D' to go right");
            }
            string val = Console.ReadLine();
            val.ToLower();

            if (val == "w" && maze[playerY - 1, playerX] != '#')
            {
                newY = playerY - 1;
            }
            else if (val == "s" && maze[playerY + 1, playerX] != '#')
            {
                newY = playerY + 1;
            }
            else if (val == "a" && maze[playerY, playerX - 1] != '#')
            {
                newX = playerX - 1;
            }
            else if (val == "d" && maze[playerY, playerX + 1] != '#')
            {
                newX = playerX + 1;
            }
            else
            {
                Console.WriteLine("You tried to walk throug a wall");
            }
            if (maze[newY, newX] != '#')
            {
                maze[playerY, playerX] = ' ';
                playerX = newX;
                playerY = newY;
                maze[playerY, playerX] = '@';
                if (playerX == mazeWidth - 2 && playerY == mazeHeight - 2)
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations! You have reached the end of the maze!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }

    static void GenerateMaze()
    {
        maze = new char[mazeHeight, mazeWidth];

        Random random = new Random();

        for (int y = 0; y < mazeHeight; y++)
        {
            for (int x = 0; x < mazeWidth; x++)
            {
                if (x == 0 || x == mazeWidth - 1 || y == 0 || y == mazeHeight - 1)
                {
                    maze[y, x] = '#';
                }
                else if (random.Next(100) < 30) // 30% chance to place a wall
                {
                    maze[y, x] = '#';
                }
                else
                {
                    maze[y, x] = ' ';
                }
            }
        }

        maze[1, 1] = '@'; // Player starting position
        maze[mazeHeight - 2, mazeWidth - 2] = 'E'; // Maze exit
    }

    static void DrawMaze()
    {
        Console.Clear();
        for (int y = 0; y < mazeHeight; y++)
        {
            for (int x = 0; x < mazeWidth; x++)
            {
                Console.Write(maze[y, x]);
            }
            Console.WriteLine();
        }
    }
}