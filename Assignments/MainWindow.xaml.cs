using System.Windows;
using System.Windows.Controls;

namespace Assignments
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ExitClick(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void MenuClick(object sender, RoutedEventArgs e)
		{
			MenuItem b = sender as MenuItem;
			switch (b.Name)
			{
				case "StackAss":
					AssignmentsDates.a2021_02_01.StackAssignment stack = new AssignmentsDates.a2021_02_01.StackAssignment();
					stack.StackCreator();
					break;
				case "LinkedListAss":
					AssignmentsDates.a2021_02_01.LinkedListAssignment linkedList = new AssignmentsDates.a2021_02_01.LinkedListAssignment();
					linkedList.LinkedListMethod();
					break;
				case "QueueAss":
					AssignmentsDates.a2021_02_01.QueueAssignment queue = new AssignmentsDates.a2021_02_01.QueueAssignment();
					queue.QueueMethod();
					break;					
				case "DictionaryAss":
					AssignmentsDates.a2021_02_01.DictionaryAssignment dict = new AssignmentsDates.a2021_02_01.DictionaryAssignment();
					dict.DictionaryMethod();
					break;
			}
		}

		private void DocumentationClick(object sender, RoutedEventArgs e)
		{
			MenuItem m = sender as MenuItem;
			AssignmentsDates.a2021_02_01.Documentationsites d = new AssignmentsDates.a2021_02_01.Documentationsites();
			d.DocuOpen(m.Name);
		}
	}
}
