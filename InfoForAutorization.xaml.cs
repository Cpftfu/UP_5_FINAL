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
	/// Логика взаимодействия для InfoForAutorization.xaml
	/// </summary>
	public partial class InfoForAutorization : Page
	{
		AutorizationTableAdapter autorization = new AutorizationTableAdapter();

		public InfoForAutorization()
		{
			InitializeComponent();
			InfosDataGrid.ItemsSource = autorization.GetData();
		}

		private void for_add_info_Click(object sender, RoutedEventArgs e)
		{
			autorization.InsertInfo(changeLoginTxtBox.Text, changePasswordTxtBox.Text, Convert.ToInt32(changeIDRoleTxtBox.Text));
			InfosDataGrid.ItemsSource = autorization.GetData();
		}

		private void for_update_info_Click(object sender, RoutedEventArgs e)
		{
			object IDAutorization = (InfosDataGrid.SelectedItem as DataRowView).Row[0];
			//autorization.UpdateInfo(changeLoginTxtBox.Text, changePasswordTxtBox.Text, Convert.ToInt32(changeIDRoleTxtBox.Text));
			InfosDataGrid.ItemsSource = autorization.GetData();
		}

		private void for_delete_info_Click(object sender, RoutedEventArgs e)
		{
			object IDAutorization = (InfosDataGrid.SelectedItem as DataRowView).Row[0];
			autorization.DeleteInfo(Convert.ToInt32(IDAutorization));
			InfosDataGrid.ItemsSource = autorization.GetData();
		}
	}
}
