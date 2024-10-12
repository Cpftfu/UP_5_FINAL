using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

using UP_FINAL.ArtistShopDataSetTableAdapters;

namespace UP_FINAL
{
	/// <summary>
	/// Логика взаимодействия для Admin.xaml
	/// </summary>
	public partial class Admin : Window
	{
		RolesTableAdapter roles = new RolesTableAdapter();
		AutorizationTableAdapter autorization = new AutorizationTableAdapter();

		public Admin()
		{
			InitializeComponent();
		}

		private void for_roles_Click(object sender, RoutedEventArgs e)
		{
			for_grid.Content = new RoleInfo();
        }

		private void for_employe_Click(object sender, RoutedEventArgs e)
		{
			for_grid.Content = new Employees();
		}

		private void for_info_Click(object sender, RoutedEventArgs e)
		{
			for_grid.Content = new InfoForAutorization();
		}

		private void for_import_roles_Click(object sender, RoutedEventArgs e)
		{
			List<RolesModel> forImportRole = ToConvert.DeserializationObject<List<RolesModel>>();
			foreach (var item in forImportRole)
			{
				roles.InsertRole(item.RoleName);
			}
		}

		private void for_import_info_Click(object sender, RoutedEventArgs e)
		{
			List<InfoModel> forImportInfo = ToConvert.DeserializationObject<List<InfoModel>>();
			foreach (var item in forImportInfo)
			{
				autorization.InsertInfo(item.loginOfRole, item.PasswordForRole, item.RoleID);
			}
		}
	}
}
