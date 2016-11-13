using System.Windows;

namespace CustomChromeSample
{
	public partial class Window2 : Window
	{
		public Window2()
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
