using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.AssignmentsDates.a2021_02_01
{
	class Documentationsites
	{
		public void DocuOpen(string btnName)
		{
			string uri="";
			switch (btnName)
			{
				case "StackDocs":
					uri = "https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-5.0";
					break;
				case "LinkedListDocs":
					uri = "https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-5.0";
					break;
				case "QueueDocs":
					uri = "https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-5.0";
					break;
				case "DictionaryDocs":
					uri = "https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-5.0";
					break;
			}
			
			var psi = new System.Diagnostics.ProcessStartInfo();
			psi.UseShellExecute = true;
			psi.FileName = uri;
			System.Diagnostics.Process.Start(psi);
		}
	}
}
