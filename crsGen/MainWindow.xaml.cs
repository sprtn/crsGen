using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace crsGen
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow: Window
	{
		Curse crs = new Curse();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void GenerateCurseBtn_Click(object sender, RoutedEventArgs e)
		{
			if (CurseBox.Visibility != Visibility.Visible)
				CurseBox.Visibility = Visibility.Visible;
			CurseBox.Text = crs.CurCurse;
		}

		private void CurseBox_MouseDown(object sender, MouseButtonEventArgs e)
		{
			CopyCursetoClipboard();
		}

		private void CopyCursetoClipboard()
		{

			Clipboard.SetText(CurseBox.Text, TextDataFormat.Text);
			notificationLabel.Content = "Curse added to clipboard!";
			//notificationLabel.HorizontalAlignment = HorizontalAlignment.Left;
			//notificationLabel.VerticalAlignment = VerticalAlignment.Top;
			notificationLabel.Visibility = Visibility.Visible;
		}

		private async void notificationLabel_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			await Task.Delay(3000);
			notificationLabel.Visibility = Visibility.Hidden;
		}

		private void CopyBtn_Click(object sender, RoutedEventArgs e)
		{
			CopyCursetoClipboard();
		}

		private void Label_MouseDown(object sender, MouseButtonEventArgs e)
		{
			CopyCursetoClipboard();
		}
	}
}
