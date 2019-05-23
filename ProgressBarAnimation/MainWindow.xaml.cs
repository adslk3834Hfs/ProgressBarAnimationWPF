using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgressBarAnimation
{
	/*
	 * Создать и анимировать свой собственный progressbar.
	 */
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			DoubleAnimation animation = new DoubleAnimation
			{
				From = rectangleProgress.Width,
				To = rectangleProgress.Width + rectangleBackground.Width,
				Duration = new Duration(TimeSpan.FromSeconds(3)),
				RepeatBehavior = RepeatBehavior.Forever,
				//AutoReverse = true
			};

			Storyboard storyboard = new Storyboard();
			storyboard.Children.Add(animation);
			Storyboard.SetTargetName(animation, rectangleProgress.Name);
			Storyboard.SetTargetProperty(animation, new PropertyPath(Rectangle.WidthProperty));
			storyboard.Begin(this);
		}
	}
}
