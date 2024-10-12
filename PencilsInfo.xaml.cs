using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
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
	/// Логика взаимодействия для PencilsInfo.xaml
	/// </summary>
	public partial class PencilsInfo : Page
	{
		PencilsTableAdapter pens = new PencilsTableAdapter();

		public PencilsInfo()
		{
			InitializeComponent();
			PencilsDataGrid.ItemsSource = pens.GetData();
		}

		private void for_add_pencils_Click(object sender, RoutedEventArgs e)
		{
			pens.InsertPencils(changePencilHardnessTxtBox.Text, changeColourOfPencilTxtBox.Text, Convert.ToInt32(changePriceeOfPencilTxtBox.Text), Convert.ToInt32(changeCategoryTxtBox.Text), Convert.ToInt32(changeBrandTxtBox.Text));
			PencilsDataGrid.ItemsSource = pens.GetData();
		}

		private void for_update_pencils_Click(object sender, RoutedEventArgs e)
		{
			object IDPencil = (PencilsDataGrid.SelectedItem as DataRowView).Row[0];
			//pens.UpdatePencils(changePencilHardnessTxtBox.Text, changeColourOfPencilTxtBox.Text, Convert.ToInt32(changePriceeOfPencilTxtBox.Text), Convert.ToInt32(changeCategoryTxtBox.Text), Convert.ToInt32(changeBrandTxtBox));
			PencilsDataGrid.ItemsSource = pens.GetData();

		}

		private void for_delete_pencils_Click(object sender, RoutedEventArgs e)
		{
			object IDPencil = (PencilsDataGrid.SelectedItem as DataRowView).Row[0];
			pens.DeletePencils(Convert.ToInt32(IDPencil));
			PencilsDataGrid.ItemsSource = pens.GetData();
		}
	}
}
