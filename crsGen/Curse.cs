using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace crsGen
{
	internal class Curse
	{
		public string CurCurse => newCurse();

		private List<string> _firstListOfStrings;
		private List<string> _secondListOfStrings;
		private List<string> _thirdListOfStrings;

		public Curse()
		{
			_firstListOfStrings = new List<string>();
			_secondListOfStrings = new List<string>();
			_thirdListOfStrings = new List<string>();
		}

		private string newCurse()
		{
			var r = new Random();

			

			return "";
		}
	}
}