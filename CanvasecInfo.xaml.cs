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
	/// Логика взаимодействия для CanvasecInfo.xaml
	/// </summary>
	public partial class CanvasecInfo : Page
	{
		CanvasesTableAdapter canva = new CanvasesTableAdapter();

		public CanvasecInfo()
		{
			InitializeComponent();
			CanvasecDataGrid.ItemsSource = canva.GetData();
		}

		private void for_add_canvaces_Click(object sender, RoutedEventArgs e)
		{
			canva.InsertCanvasec(changeTypeOfCanvasTxtBox.Text, changeCanvasMaterialTxtBox.Text, Convert.ToInt32(changePriceeOfCanvasTxtBox.Text), Convert.ToInt32(changeCategoryTxtBox.Text), Convert.ToInt32(changeBrandTxtBox.Text));
			CanvasecDataGrid.ItemsSource = canva.GetData();
		}

		private void for_update_canvaces_Click(object sender, RoutedEventArgs e)
		{
			object IDCanvas = (CanvasecDataGrid.SelectedItem as DataRowView).Row[0];
			//canva.UpdateCanvaces(changeTypeOfCanvasTxtBox.Text, changeCanvasMaterialTxtBox.Text, Convert.ToInt32(changePriceeOfCanvasTxtBox.Text), Convert.ToInt32(changeCategoryTxtBox.Text), Convert.ToInt32(changeBrandTxtBox.Text));
			CanvasecDataGrid.ItemsSource = canva.GetData();
		}

		private void for_delete_canvaces_Click(object sender, RoutedEventArgs e)
		{
			object IDCanvas = (CanvasecDataGrid.SelectedItem as DataRowView).Row[0];
			canva.DeleteCanvaces(Convert.ToInt32(IDCanvas));
			CanvasecDataGrid.ItemsSource = canva.GetData();
		}
	}
}
