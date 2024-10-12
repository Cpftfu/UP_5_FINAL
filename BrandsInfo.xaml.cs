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
	/// Логика взаимодействия для BrandsInfo.xaml
	/// </summary>
	public partial class BrandsInfo : Page
	{
		BrandsTableAdapter br = new BrandsTableAdapter();

		public BrandsInfo()
		{
			InitializeComponent();
			BrandDataGrid.ItemsSource = br.GetData();
		}

		private void for_add_br_Click(object sender, RoutedEventArgs e)
		{
			br.InsertBr(changeNameOfBrandTxtBox.Text, changeTypeOfManufTxtBox.Text);
			BrandDataGrid.ItemsSource = br.GetData();
		}

		private void for_update_br_Click(object sender, RoutedEventArgs e)
		{

		}

		private void for_delete_br_Click(object sender, RoutedEventArgs e)
		{
			object IBrand = (BrandDataGrid.SelectedItem as DataRowView).Row[0];
			br.DeleteBr(Convert.ToInt32(IBrand));
			BrandDataGrid.ItemsSource = br.GetData();
		}
	}
}
