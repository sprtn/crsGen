using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace crsGen
{
	internal class Curse
	{
		public string CurCurse => NewCurse();
		private DataSet ds = new DataSet();

		private readonly List<string> _firstListOfStrings;
		private readonly List<string> _secondListOfStrings;
		private readonly List<string> _thirdListOfStrings;

		public Curse()
		{
			_firstListOfStrings = new List<string>
			{
				"",
				""
			};
			_secondListOfStrings = new List<string>
			{
				"",
				""
			};
			_thirdListOfStrings = new List<string>
			{
				"",
				""
			};

			//DataTable x = new DataTable();
			//x.Columns.Add("Frst");
			//x.Columns.Add("Scnd");
			//x.Columns.Add("Thrd");
			//foreach (var crs in _firstListOfStrings)
			//{
			//	x.Rows.Add(crs);
			//}
		}

		public string NewCurse()
		{
			return $"{AddToCurse(new Random(), _firstListOfStrings)} " +
			       $"{AddToCurse(new Random(), _secondListOfStrings)} " +
			       $"{AddToCurse(new Random(), _thirdListOfStrings)}";
		}

		private string AddToCurse(Random r, List<string> stringList)
		{
			return stringList.ElementAt(r.Next(stringList.Count));
		}
	}
}