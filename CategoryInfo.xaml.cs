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
	/// Логика взаимодействия для CategoryInfo.xaml
	/// </summary>
	public partial class CategoryInfo : Page
	{
		CategoriesTableAdapter categ = new CategoriesTableAdapter();

		public CategoryInfo()
		{
			InitializeComponent();
			CategoriesDataGrid.ItemsSource = categ.GetData();
		}

		private void for_add_emp_Click(object sender, RoutedEventArgs e)
		{
			categ.InsertCateg(changeCategoryNameTxtBox.Text);
			CategoriesDataGrid.ItemsSource = categ.GetData();
		}

		private void for_update_emp_Click(object sender, RoutedEventArgs e)
		{

		}

		private void for_delete_emp_Click(object sender, RoutedEventArgs e)
		{
			object IDCategory = (CategoriesDataGrid.SelectedItem as DataRowView).Row[0];
			categ.DeleteCateg(Convert.ToInt32(IDCategory));
			CategoriesDataGrid.ItemsSource = categ.GetData();
		}
	}
}
