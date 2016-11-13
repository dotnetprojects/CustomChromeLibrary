using System.Windows;

namespace CustomChromeSample
{
	public partial class MainWindow : CustomChromeLibrary.CustomChromeWindow
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = this;
		}

		private void StandardChromeButton_Click(object sender, RoutedEventArgs e)
		{
			var w = new Window1();
			w.Show();
		}

		private void NoChromeButton_Click(object sender, RoutedEventArgs e)
		{
			var w = new Window2();
			w.Show();
		}

		private void NoChromeNoResizeButton_Click(object sender, RoutedEventArgs e)
		{
			var w = new Window3();
			w.Show();
		}

		private void CustomChromeButton_Click(object sender, RoutedEventArgs e)
		{
			var w = new Window4();
			w.Show();
		}

		private void CompleteCustomChromeButton_Click(object sender, RoutedEventArgs e)
		{
			var w = new Window5();
			w.Show();
		}
	}
}
