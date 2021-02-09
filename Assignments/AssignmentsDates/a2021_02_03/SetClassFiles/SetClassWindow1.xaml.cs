using System.Windows;

namespace Assignments.AssignmentsDates.a2021_02_03.SetClassFiles
{
	/// <summary>
	/// Interaction logic for SetClassWindow1.xaml
	/// </summary>
	public partial class SetClassWindow1 : Window
	{
		public SetClassWindow1()
		{
			InitializeComponent();
		}
		private void CloseClick(object sender, RoutedEventArgs e)
		{
			MsgTxt.Text = "";
			this.Close();
		}
	}
}
