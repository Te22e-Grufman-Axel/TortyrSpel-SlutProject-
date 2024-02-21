public class Maze
{
    static int mazeWidth = 40;
    static int mazeHeight = 20;
    static char[,] maze;

    static int playerX = 1;
    static int playerY = 1;

    public static void Main(string[] args)
    {
        GenerateMaze();
        DrawMaze();

        while (true)
        {
            int newX = playerX;
            int newY = playerY;

            if (maze[playerY - 1, playerX] != '#')
            {
                Console.WriteLine("Write 'W' to go upp");
            }
            else if (maze[playerY - 1, playerX] != '#')
            {
                Console.WriteLine("Write 's' to go down");
            }
            else if (maze[playerY - 1, playerX] != '#')
            {
                Console.WriteLine("Write 'A' to go left");
            }
            else if (maze[playerY - 1, playerX] != '#')
            {
                Console.WriteLine("Write 'D' to go right");
            }
            string val = Console.ReadLine();
            val.ToLower();

            if (val == "w")
            {
                newY = playerY - 1;
            }
            else if (val == "s")
            {
                newY = playerY + 1;
            }
            else if (val == "a")
            {
                newX = playerX - 1;
            }
            else if (val == "d")
            {
                newX = playerX + 1;
            }

            if (maze[newY, newX] != '#')
            {
                Console.SetCursorPosition(playerX, playerY);
                Console.Write(' ');
                playerX = newX;
                playerY = newY;
                Console.SetCursorPosition(playerX, playerY);
                Console.Write('@');

                if (playerX == mazeWidth - 2 && playerY == mazeHeight - 2)
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations! You have reached the end of the maze!");
                    break;
                }
            }
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