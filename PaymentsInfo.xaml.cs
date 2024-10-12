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
	/// Логика взаимодействия для PaymentsInfo.xaml
	/// </summary>
	public partial class PaymentsInfo : Page
	{
		PaymentsTableAdapter pay = new PaymentsTableAdapter();

		public PaymentsInfo()
		{
			InitializeComponent();
			PaymentsDataGrid.ItemsSource = pay.GetData();
		}

		private void for_add_pay_Click(object sender, RoutedEventArgs e)
		{
			pay.InsertPay(Convert.ToInt32(changeAmountTxtBox.Text), Convert.ToInt32(changeOrderTxtBox.Text), Convert.ToInt32(changeCategoryTxtBox.Text));
			PaymentsDataGrid.ItemsSource = pay.GetData();
		}

		private void for_update_pay_Click(object sender, RoutedEventArgs e)
		{

		}

		private void for_delete_pay_Click(object sender, RoutedEventArgs e)
		{
			object IDPayment = (PaymentsDataGrid.SelectedItem as DataRowView).Row[0];
			pay.DeletePay(Convert.ToInt32(IDPayment));
			PaymentsDataGrid.ItemsSource = pay.GetData();
		}
	}
}
