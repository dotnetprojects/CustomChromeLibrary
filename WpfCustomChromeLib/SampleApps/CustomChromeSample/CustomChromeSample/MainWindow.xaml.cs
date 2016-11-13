using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Shell;

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
