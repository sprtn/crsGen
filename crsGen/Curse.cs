using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace crsGen
{
	public class Curse
	{
		[Description("Calling a new curse from the lib")]
		public string CurCurse => NewCurse();

		public List<int> Former = new List<int>();

		private static readonly Random R = new Random();
		private static readonly object SyncLock = new object();

		private readonly List<List<List<string>>> fullList = new List<List<List<string>>>
		{
			// First list of insults
			new List<List<string>>
			{
				new List<string>
				{
					"I'd fuck your",
					"I slap your",
					"Suck on this",
					//"Your mother is a",
					"I fill every",
					"I would easily ejaculate on your",
					"Fuck this",
					"Smells like it's"
				},
				new List<string>
				{
					"shit",
					"asshole",
					"tits",
					"bitch",
					//"wide fucking",
					"avocado-patch",
					"cunt"
				},
				new List<string>
				{
					"for dinner",
					"while masturbating",
					"with melted cheese on top",
					"for no specific reason",
					"while touching your cousin",
					"without even looking",
					"inside your vag",
					"with your sister watching"
				}
			},

			// Second list of insults
			new List<List<string>>
			{
				new List<string>
				{
					//A, B, C, D, E
					"Anal",
					"Suck on this, you",

					//F, G, H, I, J
					"Fucking",

					//K, L, M, N, O
					"Motherfucking",

					//P, Q, R, S, T

					//U, V, W, X, Y, Z
					"You"
				},
				new List<string>
				{
					//A, B, C, D, E
					"turd loving",

					//F, G, H, I, J
					"goat-loving",
					"god damn",
					"interjaculate",

					//K, L, M, N, O
					"little",

					//P, Q, R, S, T
					"shit-covered"

					//U, V, W, X, Y, Z

				},
				new List<string>
				{
					//A, B, C, D, E
					"arsebadgering",
					"blasted",
					"cup-fucking",
					"cum-sipping",

					//F, G, H, I, J
					"flower-sniffing",
					"frazzlin",
					"freakin'",
					"jumping",

					//K, L, M, N, O
					"kremlin-inspecting",
					"Legolas-lookalike",
					"Mario-playing",
					"Mustard",

					//P, Q, R, S, T
					"rimjob-giving",
					"treehugging"

					//U, V, W, X, Y, Z

				},
				new List<string>
				{
					//A, B, C, D, E
					"asshole",
					"ass-jabber",
					"bitch",
					"bag of dicks",
					"broner",
					"butt-pirate",
					"cunt",
					"cumbubble",
					"cocknose",
					"dick",
					"dickweed",
					"democrat",

					//F, G, H, I, J
					"fuck",
					"fuck trumpet",
					"hard-on",

					//K, L, M, N, O
					"knob",
					"nupson",
					"onanist",

					//P, Q, R, S, T
					"prick",
					"shart",
					"shit",
					"shit-wad",
					"twat",

					//U, V, W, X, Y, Z
					"vegetarian",
					"whore",
					"xanthippe",
					"yarak",
					"zatch"
				}
			},

			// Third list of insults
			new List<List<string>>{
				new List<string>
				{
					"Monkeydonking honkeydick.",
					"You fat infertile son of a janitor.",
					"Sloppy joes look better than you.",
					"Why don't you put down that bag of dicks.",
					"You smell even worse than you look.",
					"Someone should slap your parents.",
					"I sincerely hope you aren't allowed to breed.",
					"For your family's sake, I hope you were adopted.",
					"Eat my asshole?",
					"Toss my salad.",
					"Eva Braun would like you."
				}
			}
		};

		public string NewCurse()
		{
			var inputList = fullList.ElementAt(R.Next(fullList.Count));

			string s = "";
			foreach (List<string> subList in inputList)
				s += $"{subList.ElementAt(RandomNumber(subList.Count - 1))} ";
			return s;
		}

		private static int RandomNumber(int max)
		{
			lock (SyncLock) // synchronize
				return R.Next(max);
		}
	}
}