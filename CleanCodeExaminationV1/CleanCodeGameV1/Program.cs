using System;
using System.IO;
using System.Collections.Generic;

namespace CleanCodeExaminationV1
{
	class Program
	{
		public static void Main(string[] args)
		{
			IUserInterface ui = new ConsoleIO();
			IGame game = new MooGame();
			IHighScore highScore = new TextFile(game.Name);
			
			GameController controller = new(ui, game, highScore);

			controller.Run();
		}
		
	}
}