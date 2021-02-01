using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.AssignmentsDates.a2021_02_01
{
	//Dit slut-resultat skal være en LinkedList med alle 12 måneder der står korrekt.
	class LinkedListAssignment
	{
		public void LinkedListMethod()
		{
			string[] mnths =
			{ "Februar", "Marts", "Maj", "Juni", "Juli", "August", "Oktober", "November" };			
			LinkedList<string> monthsList = new LinkedList<string>(mnths);
			string outputValue = "Start-LinkedList:\n";
			foreach (string s in monthsList)
			{
				outputValue += s + "  ";
			}
			
			monthsList.AddFirst("Januar");
			outputValue += "\n\nAdded Januar:\n";
			foreach (string s in monthsList)
			{
				outputValue += s + "  ";
			}
			
			monthsList.AddBefore(monthsList.Find("Maj"), "April");
			outputValue += "\n\nAdded April:\n";
			foreach (string s in monthsList)
			{
				outputValue += s + "  ";
			}

			monthsList.AddAfter(monthsList.Find("August"), "September");
			outputValue += "\n\nAdded September:\n";
			foreach (string s in monthsList)
			{
				outputValue += s + "  ";
			}
			
			monthsList.AddLast("December");
			outputValue += "\n\nAdded December:\n";
			foreach (string s in monthsList)
			{
				outputValue += s + "  ";
			}
			
			View.Windows.ReturnWindow rw = new View.Windows.ReturnWindow();
			rw.MsgTxt.Text = outputValue;
			rw.Show();
		}
	}
}
