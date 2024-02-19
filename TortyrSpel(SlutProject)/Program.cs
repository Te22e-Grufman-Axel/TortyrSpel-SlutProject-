String Level = "Start";
int[,] board = new int[100, 30];
for (int y = 0; y < board.GetLength(1); y++)
{
  for (int x = 0; x < board.GetLength(0); x++)
  {
    Console.Write(board[x, y]); // Ritar ut den nuvarande rutan
  }
  Console.WriteLine(); // Lägger till en radbrytning i slutet på varje utritad rad.
}



Console.ReadLine();