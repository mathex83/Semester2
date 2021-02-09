using System.Windows;

namespace Assignments.AssignmentsDates.a2021_02_03.SetClassFiles
{
	/// <summary>
	/// Interaction logic for SetClassWindow3.xaml
	/// </summary>
	public partial class SetClassWindow3 : Window
	{
		public SetClassWindow3()
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
