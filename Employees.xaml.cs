using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
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
	/// Логика взаимодействия для Employees.xaml
	/// </summary>
	public partial class Employees : Page
	{
		EmployeesTableAdapter employer = new EmployeesTableAdapter();

		public Employees()
		{
			InitializeComponent();
			EmployeesDataGrid.ItemsSource = employer.GetData();
		}

		private void for_add_emp_Click(object sender, RoutedEventArgs e)
		{
			employer.InsertEmp(changeEmployeeNameTxtBox.Text, changeEmployeeSurNameTxtBox.Text, changeEmployeeMiddleNameTxtBox.Text, Convert.ToInt32(changeRoleTxtBox.Text), Convert.ToInt32(changeOrderTxtBox.Text));
			EmployeesDataGrid.ItemsSource = employer.GetData();
		}

		private void for_update_emp_Click(object sender, RoutedEventArgs e)
		{

		}

		private void for_delete_emp_Click(object sender, RoutedEventArgs e)
		{
			object IDEmployee = (EmployeesDataGrid.SelectedItem as DataRowView).Row[0];
			employer.DeleteEmp(Convert.ToInt32(IDEmployee));
			EmployeesDataGrid.ItemsSource = employer.GetData();
		}
	}
}
