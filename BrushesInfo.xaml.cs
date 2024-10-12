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
	/// Логика взаимодействия для BrushesInfo.xaml
	/// </summary>
	public partial class BrushesInfo : Page
	{
		BrushesTableAdapter brush = new BrushesTableAdapter();

		public BrushesInfo()
		{
			InitializeComponent();
			BrushesDataGrid.ItemsSource = brush.GetData();
		}

		private void for_add_brushes_Click(object sender, RoutedEventArgs e)
		{
			brush.InsertBrushes(changeBrushShapesTxtBox.Text, Convert.ToInt32(changeSizeOfBrushTxtBox.Text), Convert.ToInt32(changePriceeOfBrushTxtBox.Text), Convert.ToInt32(changeCategoryTxtBox.Text), Convert.ToInt32(changeBrandTxtBox.Text));
			BrushesDataGrid.ItemsSource = brush.GetData();
		}

		private void for_update_brushes_Click(object sender, RoutedEventArgs e)
		{
			object IDBrush = (BrushesDataGrid.SelectedItem as DataRowView).Row[0];
			//brush.UpdateBrushes();
			BrushesDataGrid.ItemsSource = brush.GetData();
		}

		private void for_delete_brushes_Click(object sender, RoutedEventArgs e)
		{
			object IDBrush = (BrushesDataGrid.SelectedItem as DataRowView).Row[0];
			brush.DeleteBrushes(Convert.ToInt32(IDBrush));
			BrushesDataGrid.ItemsSource = brush.GetData();
		}
	}
}
