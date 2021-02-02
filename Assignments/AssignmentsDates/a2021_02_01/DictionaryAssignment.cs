using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.AssignmentsDates.a2021_02_01
{
	class DictionaryAssignment
	{
		/// <summary>
		///	Make a Dictionary with Star Wars persons as keys.
		/// each get a true/false if they are jedi/not jedi as value.
		/// Iterate over them and show jedi status.
		/// </summary>

		public void DictionaryMethod()
		{
			string outputvalue = "";
			Dictionary<string, bool> chars = new Dictionary<string, bool>();
			chars.Add("Luke", true);
			chars.Add("Chewie", false);
			chars.Add("Han Solo", false);
			chars.Add("Yoda", true);
			chars.Add("Leia", false);
			foreach (KeyValuePair<string, bool> kvp in chars)
			{
				if (kvp.Value)
				{
					outputvalue += $"{kvp.Key} is a jedi.\n";
				}
				else
				{
					outputvalue += $"{kvp.Key} is not a jedi.\n";
				}				
			}
			View.Windows.ReturnWindow rw = new View.Windows.ReturnWindow();
			rw.MsgTxt.Text = outputvalue;
			rw.Show();
		}

	}
}
