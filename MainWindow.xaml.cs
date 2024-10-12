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
using System.Windows.Navigation;
using System.Windows.Shapes;

using UP_FINAL.ArtistShopDataSetTableAdapters;

namespace UP_FINAL
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		AutorizationTableAdapter adapter = new AutorizationTableAdapter();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void for_log_in_Click(object sender, RoutedEventArgs e)
		{
			var allGovno = adapter.GetData().Rows;
			bool isAutorization = false;

			for (int i = 0; i < allGovno.Count; i++)
			{
				if (allGovno[i][1].ToString() == for_login.Text &&
					allGovno[i][2].ToString() == for_password.Password)
				{
					isAutorization = true;
					int roleId = (int)allGovno[i][3];

					switch (roleId)
					{
						case 1:
							Maneger man = new Maneger();
							man.Show();
							this.Close();
							break;
						case 2:
							Admin adm = new Admin();
							adm.Show();
							this.Close();
							break;
						case 3:
							Cashier cash = new Cashier();
							cash.Show();
							break;
					}
					break;
				}
			}

			if (!isAutorization)
			{
				MessageBox.Show("Некорректный логин или пароль. Пожалуйста, попробуйте снова.");
			}
		}
	}
}
