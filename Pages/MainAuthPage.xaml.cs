using PracticalWork12.windows;
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

namespace PracticalWork12.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainAuthPage.xaml
    /// </summary>
    public partial class MainAuthPage : Page
    {
        public MainAuthPage()
        {
            InitializeComponent();
            DataContext = Helpers.Helpers.CurrentUser;
        }

        private void ButtonProducts_Click(object sender, RoutedEventArgs e)
        {
            ItemWindow itemWindow = new ItemWindow();
            itemWindow.Show();

            Window.GetWindow(this)?.Close();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            DataContext = Helpers.Helpers.CurrentUser;
            DataContext = null;

            Helpers.Helpers.label.Content = "Главная страница";
            Helpers.Helpers.frame.Navigate(new MainPage());
        }
    }
}
