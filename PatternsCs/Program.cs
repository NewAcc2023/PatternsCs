using PatternsCs;
using System.Security.Cryptography.X509Certificates;

LevelManagerSingleton managerSingleton = LevelManagerSingleton.GetInstance();
int score = 0;
bool isOpen = true;
int foodX;
int foodY;

int userX;
int userY;

void DrawNewMap() 
{
	Console.Clear();
	managerSingleton.GoToNextLevel();
	Random r = new Random();
	foodX = r.Next(0, 20);
	foodY = r.Next(0, 20);

	userX = r.Next(0, 20);
	userY = r.Next(0, 20);
	score += managerSingleton.GetCurrentLevel() * r.Next(1,9) * 100;
	for (int i = 0; i < 20; i++)
	{
		for (int j = 0; j < 20; j++)
		{
			if (i == foodX && j == foodY)
			{
				Console.Write("F");
			}
			else
			{
				Console.Write(".");
			}

		}
		Console.WriteLine();
	}
	Console.WriteLine($"Score: {score} Level: {managerSingleton.GetCurrentLevel()}");
}

DrawNewMap();
Console.CursorVisible = false;

while (isOpen) 
{
    if (userY == foodX && userX == foodY)
    {
		DrawNewMap();
	}

	Console.SetCursorPosition(userX, userY);

	Console.Write("U");

	ConsoleKeyInfo k = Console.ReadKey();
	if(k.Key == ConsoleKey.UpArrow && userY>0) 
	{
		userY--;
	}
	if (k.Key == ConsoleKey.DownArrow)
	{
		userY++;
	}
	if (k.Key == ConsoleKey.LeftArrow && userX > 0)
	{
		userX--;
	}
	if (k.Key == ConsoleKey.RightArrow)
	{
		userX++;
	}
}
