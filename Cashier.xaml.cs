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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UP_FINAL
{
	/// <summary>
	/// Логика взаимодействия для Cashier.xaml
	/// </summary>
	public partial class Cashier : Window
	{
		public Cashier()
		{
			InitializeComponent();
		}

		private void for_brushes_Click(object sender, RoutedEventArgs e)
		{
			for_grid.Content = new BrushesInfo();
		}

		private void for_paints_Click(object sender, RoutedEventArgs e)
		{
			for_grid.Content = new PaintsInfo();
		}

		private void for_pencils_Click(object sender, RoutedEventArgs e)
		{
			for_grid.Content = new PencilsInfo();
		}

		private void for_canvases_Click(object sender, RoutedEventArgs e)
		{
			for_grid.Content = new CanvasecInfo();
		}

		private void for_easels_Click(object sender, RoutedEventArgs e)
		{
			for_grid.Content = new EaselsInfo();
		}
	}
}
