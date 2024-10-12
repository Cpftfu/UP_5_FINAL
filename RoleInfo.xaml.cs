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
	/// Логика взаимодействия для RoleInfo.xaml
	/// </summary>
	public partial class RoleInfo : Page
	{
		RolesTableAdapter roles = new RolesTableAdapter();

		public RoleInfo()
		{
			InitializeComponent();
			RoleDataGrid.ItemsSource = roles.GetData();
		}

		private void for_add_role_Click(object sender, RoutedEventArgs e)
		{
			roles.InsertRole(changeRoleNameTxtBox.Text);
			RoleDataGrid.ItemsSource = roles.GetData();
		}

		private void for_update_role_Click(object sender, RoutedEventArgs e)
		{

		}

		private void for_delete_role_Click(object sender, RoutedEventArgs e)
		{
			object IDRole = (RoleDataGrid.SelectedItem as DataRowView).Row[0];
			roles.DeleteRole(Convert.ToInt32(IDRole));
			RoleDataGrid.ItemsSource = roles.GetData();
		}
	}
}
