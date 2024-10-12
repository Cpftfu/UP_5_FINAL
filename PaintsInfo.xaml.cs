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
	/// Логика взаимодействия для PaintsInfo.xaml
	/// </summary>
	public partial class PaintsInfo : Page
	{
		PaintsTableAdapter paint = new PaintsTableAdapter();

		public PaintsInfo()
		{
			InitializeComponent();
			PaintsDataGrid.ItemsSource = paint.GetData();
		}

		private void for_add_Paints_Click(object sender, RoutedEventArgs e)
		{
			paint.InsertPaints(changeColourOfPaintTxtBox.Text, changeTypeOfPaintTxtBox.Text, Convert.ToInt32(changePriceeOfPaintTxtBox.Text), Convert.ToInt32(changeCategoryTxtBox.Text), Convert.ToInt32(changeBrandTxtBox.Text));
			PaintsDataGrid.ItemsSource = paint.GetData();
		}

		private void for_update_Paints_Click(object sender, RoutedEventArgs e)
		{
			object IDPaint = (PaintsDataGrid.SelectedItems as DataRowView).Row[0];
			//paint.UpdatePaints(changeColourOfPaintTxtBox.Text, changeTypeOfPaintTxtBox.Text, Convert.ToInt32(changePriceeOfPaintTxtBox.Text), Convert.ToInt32(changeCategoryTxtBox.Text), Convert.ToInt32(changeBrandTxtBox.Text));
			PaintsDataGrid.ItemsSource = paint.GetData();
		}

		private void for_delete_Paints_Click(object sender, RoutedEventArgs e)
		{
			object IDPaint = (PaintsDataGrid.SelectedItems as DataRowView).Row[0];
			paint.DeletePaints(Convert.ToInt32(IDPaint));
			PaintsDataGrid.ItemsSource = paint.GetData();
		}
	}
}
