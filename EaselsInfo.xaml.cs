using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
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
	/// Логика взаимодействия для EaselsInfo.xaml
	/// </summary>
	public partial class EaselsInfo : Page
	{
		EaselsTableAdapter easel = new EaselsTableAdapter();

		public EaselsInfo()
		{
			InitializeComponent();
			EaselsDataGrid.ItemsSource = easel.GetData();
		}

		private void for_add_easel_Click(object sender, RoutedEventArgs e)
		{
			easel.InsertEasels(changeTypeOfEaselTxtBox.Text, Convert.ToInt32(changePriceeOfEaselTxtBox.Text), Convert.ToInt32(changeCategoryTxtBox.Text), Convert.ToInt32(changeBrandTxtBox.Text));
			EaselsDataGrid.ItemsSource = easel.GetData();
		}

		private void for_update_easel_Click(object sender, RoutedEventArgs e)
		{
			object IDEasel = (EaselsDataGrid.SelectedItem as DataRowView).Row[0];
			//easel.UpdateEasels(Convert.ToInt32(IDEasel), changeTypeOfEaselTxtBox.Text, Convert.ToInt32(changePriceeOfEaselTxtBox.Text), Convert.ToInt32(changeCategoryTxtBox.Text), Convert.ToInt32(changeBrandTxtBox.Text));
			EaselsDataGrid.ItemsSource = easel.GetData();
		}

		private void for_delete_easel_Click(object sender, RoutedEventArgs e)
		{
			object IDEasel = (EaselsDataGrid.SelectedItem as DataRowView).Row[0];
			easel.DeleteEasels(Convert.ToInt32(IDEasel));
			EaselsDataGrid.ItemsSource = easel.GetData();
		}
	}
}
