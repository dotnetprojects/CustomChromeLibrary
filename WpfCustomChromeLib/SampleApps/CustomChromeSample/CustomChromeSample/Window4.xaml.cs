using System.Windows;

namespace CustomChromeSample
{
	public partial class Window4 : Window
	{
		public Window4()
		{
			InitializeComponent();
			DataContext = this;
		}

		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}
