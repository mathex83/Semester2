using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.AssignmentsDates.a2021_02_01
{
	class StackAssignment
	{
		//Make a Stack.
		//Add some Star Wars-movies to it.
		//Empty the Stack.
		public void StackCreator()
		{
			string outputvalue = "";
			Stack<string> movies = new Stack<string>();
			movies.Push("The Empire Strikes Back");
			movies.Push("A New Hope");
			movies.Push("The Phantom Menace");

			do
			{
				outputvalue += $"Movie removed: {movies.Pop()}\n";
			}
			while (movies.Count > 0);
			outputvalue += $"\nThe Stack now has {movies.Count} entries";
			View.Windows.ReturnWindow rw = new View.Windows.ReturnWindow();
			rw.MsgTxt.Text = outputvalue;
			rw.Show();
		}
	}
}
