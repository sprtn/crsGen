using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace crsGen
{
	internal class Curse
	{
		[Description("Calling a new curse from the lib")]
		public string CurCurse => NewCurse();

		public List<int> Former = new List<int>();

		static Random r = new Random();
		static object syncLock = new object();

		private readonly List<string> _firstListOfStrings;
		private readonly List<string> _secondListOfStrings;
		private readonly List<string> _thirdListOfStrings;

		private List<List<string>> ListOfStringLists = new List<List<string>>
		{
			new List<string>(),
			new List<string>(),
			new List<string>()
		};

		public Curse()
		{
			_firstListOfStrings = new List<string>
			{
				"Fuck your",
				"I slap your",
				"Come dance with me, you",
				"Your mother's",
				"I fill every",
				"I'd ejaculate on your",
				"Fuck this",
				"Fornicate with"
			};

			_secondListOfStrings = new List<string>
			{
				"shit",
				"tits",
				"bitches",
				"wide fucking",
				"avocado-patch",
				"cunt"
			};

			_thirdListOfStrings = new List<string>
			{
				"for dinner",
				"right before noon",
				"with melted cheese on top",
				"for no specific reason"
			};
			
			ListOfStringLists.Add(_firstListOfStrings);
			ListOfStringLists.Add(_secondListOfStrings);
			ListOfStringLists.Add(_thirdListOfStrings);
		}

		public string NewCurse()
		{
			PopulateIntListWithNumbers();
			
			return $"{AddToCurse(Former[0], _firstListOfStrings)} " +
			       $"{AddToCurse(Former[1], _secondListOfStrings)} " +
			       $"{AddToCurse(Former[2], _thirdListOfStrings)}";
			
		}

		private void PopulateIntListWithNumbers()
		{
			if (Former.Count != 0)
			{
				for (int curIndex = 0; curIndex < Former.Count; curIndex++)
				{
					int curNum = -1;
					try
					{
						curNum = Former[curIndex];
					}
					catch
					{
						// This is broken af. Tried to add the RandomNumber method, but alas. To no avail.
					}
					finally
					{
						if (curNum != -1)
						{
							int nextNum = Former.ElementAt(curIndex);
							do
								curNum = RandomNumber(ListOfStringLists.ElementAt(curIndex).Count);
							while (curNum == -1 || curNum == nextNum);
							Former[curIndex] = curNum;
						} else
							Former[curIndex] = RandomNumber(ListOfStringLists[curIndex].Count);
					}
				}
			}
			else
				Former = new List<int>
				{	
					RandomNumber(_firstListOfStrings.Count),
					RandomNumber(_secondListOfStrings.Count),
					RandomNumber(_thirdListOfStrings.Count),
				};
		}

		private static int RandomNumber(int max)
		{
			lock (syncLock) // synchronize
				return r.Next(max);
		}

		private string AddToCurse(int i, List<string> stringList)
		{
			return stringList.ElementAt(i);
		}
	}
}