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
	/// Логика взаимодействия для Maneger.xaml
	/// </summary>
	public partial class Maneger : Window
	{
		public Maneger()
		{
			InitializeComponent();
		}

		private void for_orders_Click(object sender, RoutedEventArgs e)
		{
			for_grid.Content = new OrdersInfo();
		}

		private void for_brands_Click(object sender, RoutedEventArgs e)
		{
			for_grid.Content = new BrandsInfo();
		}

		private void for_paymants_Click(object sender, RoutedEventArgs e)
		{
			for_grid.Content = new PaymentsInfo();
		}
	}
}
