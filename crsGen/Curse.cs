using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

// ----------------------------------------
//		Made by Vegard Bratteng @ vebr.no
// ----------------------------------------

namespace crsGen
{
	public class Curse
	{
		[Description("Calling a new curse from the lib")]
		public string CurCurse => NewCurse();

		public List<int> Former = new List<int>();

		private static readonly Random R = new Random();
		private static readonly object SyncLock = new object();

		private readonly List<List<List<string>>> _fullList = new List<List<List<string>>>
		{
			// First list of insults
			new List<List<string>>
			{
				new List<string>
				{
					"I'd fuck your",
					"I slap your",
					"Suck on",
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
					"Anal",
					"Suck on this, you",
					"Fucking",
					"Motherfucking",
					"You"
				},
				new List<string>
				{
					"turd loving",
					"goat-loving",
					"god damn",
					"interjaculate",
					"little",
					"shit-covered"
				},
				new List<string>
				{
					"arsebadgering",
					"blasted",
					"cup-fucking",
					"cum-sipping",
					"flower-sniffing",
					"frazzlin",
					"freakin'",
					"jumping",
					"kremlin-inspecting",
					"Legolas-lookalike",
					"Mario-playing",
					"Mustard",
					"rimjob-giving",
					"treehugging"
				},
				new List<string>
				{
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
					"fuck",
					"fuck trumpet",
					"hard-on",
					"knob",
					"nupson",
					"onanist",
					"prick",
					"shart",
					"shit",
					"shit-wad",
					"twat",
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
			var inputList = _fullList.ElementAt(R.Next(_fullList.Count));

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

/*
 * BUGLIST:
 * 
 * Copy button crashes the application on Win 7?
 */