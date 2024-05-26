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

namespace Суюндукова_София.WindowAppication
{
    /// <summary>
    /// Логика взаимодействия для MainWindowLK.xaml
    /// </summary>
    public partial class MainWindowLK : Window
    {
        public MainWindowLK()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переходим в окно заказов
        /// </summary>
        private void Button_Orders(object sender, RoutedEventArgs e)
        {
            OrdersWindow ordersWindow = new OrdersWindow();
            ordersWindow.Show();
            this.Close();
        }
    }
}
