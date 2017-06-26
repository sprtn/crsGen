using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace crsGen
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow: Window
	{
		private readonly Curse _crs = new Curse();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void GenerateCurseBtn_Click(object sender, RoutedEventArgs e)
		{
			if (CurseBox.Visibility != Visibility.Visible)
				CurseBox.Visibility = Visibility.Visible;
			CurseBox.Text = _crs.CurCurse;
		}

		private void CurseBox_MouseDown(object sender, MouseButtonEventArgs e)
		{
			CopyCursetoClipboard();
		}

		[STAThread]
		private void CopyCursetoClipboard()
		{
			Clipboard.SetText(CurseBox.Text, TextDataFormat.Text);
			notificationLabel.Content = "Curse added to clipboard!";
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
