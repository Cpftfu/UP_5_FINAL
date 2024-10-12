using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

using UP_FINAL.ArtistShopDataSetTableAdapters;

namespace UP_FINAL
{
	/// <summary>
	/// Логика взаимодействия для OrdersInfo.xaml
	/// </summary>
	public partial class OrdersInfo : Page
	{
		OrdersTableAdapter ord = new OrdersTableAdapter();

		public OrdersInfo()
		{
			InitializeComponent();
			OrdersDataGrid.ItemsSource = ord.GetData();
		}

		private void for_add_ord_Click(object sender, RoutedEventArgs e)
		{
			DateTime orderDate;

			if (DateTime.TryParse(changeDateOfOrderTxtBox.Text, out orderDate))
			{
				ord.InsertDataOrder(orderDate.ToString("MM/dd/yyyy"));
				OrdersDataGrid.ItemsSource = ord.GetData();
			}
			else
			{
				MessageBox.Show("Пожалуйста введите корректную дату!");
			}
		}

		private void for_update_ord_Click(object sender, RoutedEventArgs e)
		{

		}

		private void for_delete_ord_Click(object sender, RoutedEventArgs e)
		{
			object IDOrder = (OrdersDataGrid.SelectedItem as DataRowView).Row[0];
			ord.DeleteDataOrder(Convert.ToInt32(IDOrder));
			OrdersDataGrid.ItemsSource = ord.GetData();
		}
	}
}
