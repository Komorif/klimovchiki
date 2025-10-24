using PracticalWork12.Pages;
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

namespace PracticalWork12.windows
{
    /// <summary>
    /// Логика взаимодействия для ItemWindow.xaml
    /// </summary>
    public partial class ItemWindow : Window
    {
        public ItemWindow()
        {
            InitializeComponent();
            ListViewItems.ItemsSource = Helpers.Helpers.DB.Products.ToList();
            DataContext = Helpers.Helpers.CurrentUser;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext == null)
            {
                Helpers.Helpers.label.Content = "Главная страница";

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }

            else if (DataContext != null)
            {
                Helpers.Helpers.label.Content = "Основная страница";

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }
    }
}
