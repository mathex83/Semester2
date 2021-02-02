using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace Assignments.View.Windows
{
	/// <summary>
	/// Du arbejder i en bank, i et call center, og skal nu lave et call system. Du skal lave 
	/// en løsning for dem som tager imod opkald i callcenteret. De skal have et program som 
	/// består af 2 knapper, tag næste opkald, og afslut opkald.
	/// Du skal lave en collection af tilfældige kunder som ringer ind, og bliver sat i kø.
	/// Det skal så være muligt med et buttonclick at "tage et opkald" og "afslutte opkald" 
	/// hvorpå der skal gemmes et timestamp hvornår opkaldet blev taget imod, samt afsluttet.
	/// </summary>
	public partial class QueueAssignmentWindow : Window
	{
		public int timer = 1200;
		public Random r = new Random();
		public Queue<string> numberQueue = new Queue<string>();
		public Queue<string> incomingQueue = new Queue<string>();
		public Queue<string> takenQueue = new Queue<string>();
		public Queue<string> endedQueue = new Queue<string>();
		public string processingCall = "";
		public int end = 0;
		public string callListAsString = "";

		public QueueAssignmentWindow()
		{
			InitializeComponent();
		}

		private void Callcenter(object sender, RoutedEventArgs e)
		{
			Button b=sender as Button;
			switch (b.Name)
			{
				case "logbtn":
					StartUp();
					break;
				case "addbtn":
					Queuing();
					break;
				case "takebtn":
					TakeCall();
					break;
				case "endbtn":
					EndCall();
					break;
			}
		}

		private void StartUp()
		{
			if (incomingQueue.Count > 0 || takenQueue.Count > 0)
			{
				incomingQueue.Clear();
				takenQueue.Clear();
				incomingqueuetxt.Text = "";
			}
		}

		int counter = 0;
		private void Queuing()
		{
			string phoneNumber;
			if (incomingQueue.Count == 0)
			{
				counter = 0;				
			}
			
			phoneNumber = r.Next(0, 100000000).ToString("D8");
			if (numberQueue.Contains(phoneNumber))
			{
				phoneNumber = r.Next(1, 100000000).ToString("D8");
			}
			else
			{
				callListAsString = "";
				numberQueue.Enqueue(phoneNumber);
				incomingQueue.Enqueue($"{(counter + 1).ToString("D3")}.  {phoneNumber}\tCall arrived: {DateTime.Now}");
				
				foreach(string s in incomingQueue)
				{
					callListAsString += s + "\n";
				}
				incomingqueuetxt.Text = callListAsString;
				counter++;
			}
			//adds a timer so the time is not being the same for every call	
			Thread.Sleep(timer);
		}

		private void TakeCall()
		{
			if (numberQueue.Count >= 1 && incomingQueue.Count >= 1)
			{
				string currentCall = numberQueue.Dequeue();
				takenQueue.Enqueue(incomingQueue.Dequeue() + "\n\tCall taken: " + DateTime.Now);
				calltaken.Text = currentCall + "\tCall taken: " + DateTime.Now;
				callListAsString = "";
				foreach (string s in incomingQueue)
				{
					callListAsString += s + "\n";
				}
				incomingqueuetxt.Text = callListAsString;
			}
			else
			{				
				calltaken.Text = "";
			}			
		}

		private void EndCall()
		{
			if (takenQueue.Count>=1)
			{
				calltaken.Text = "";
				callListAsString = "";
				endedQueue.Enqueue(takenQueue.Dequeue() + $"\tCall ended: { DateTime.Now}");
				foreach (string s in endedQueue)
				{
					callListAsString += $"{s}\n";
				}
				endqueuetxt.Text = callListAsString;
			}			
		}

		private void CloseClick(object sender, RoutedEventArgs e)
		{
			if (incomingQueue.Count > 0)
			{
				numberQueue.Clear();
				incomingQueue.Clear();
				takenQueue.Clear();
			}
			this.Close();
		}
	}
}
