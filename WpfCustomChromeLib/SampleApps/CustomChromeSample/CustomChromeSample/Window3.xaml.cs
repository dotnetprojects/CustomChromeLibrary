using System.Windows;

namespace CustomChromeSample
{
	public partial class Window3 : Window
	{
		public Window3()
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
