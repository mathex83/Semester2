using System.Windows;

namespace Assignments.AssignmentsDates.a2021_02_03.SetClassFiles
{
	/// <summary>
	/// Interaction logic for SetClassWindow2.xaml
	/// </summary>
	public partial class SetClassWindow2 : Window
	{
		public SetClassWindow2()
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
