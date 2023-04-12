using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsCs
{
	public class LevelManagerSingleton
	{
		private static LevelManagerSingleton? managerSingleton;
		private int currentLevel;
		private LevelManagerSingleton()
		{
			currentLevel = 0;
		}

		public static LevelManagerSingleton GetInstance()
		{
			if (managerSingleton == null)
			{
				managerSingleton = new LevelManagerSingleton();
			}
			return managerSingleton;
		}

		public int GetCurrentLevel()
		{
			
			return currentLevel;
		}

		public void GoToNextLevel()
		{
			currentLevel++;
		}
	}
}
