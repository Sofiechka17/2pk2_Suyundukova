using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    /// Логика взаимодействия для AddServices.xaml
    /// </summary>
    public partial class AddServices : Window
    {
        internal event EventHandler<Library.Service> ServicesAddEvent; //событие добавления объекта
        internal void OnServicesAddEvent(Library.Service services) // OnServicesAddEvent
        {
            ServicesAddEvent?.Invoke(this, services);
        }

        public AddServices(Window owner)
        {
            InitializeComponent();
            this.Owner = owner;
        }

        /// <summary>
        /// Добавление заказа в дочернее окно
        /// </summary>
        private void AddService(object sender, RoutedEventArgs e)
        {
            OnServicesAddEvent(new Library.Service(Name.Text)); 
            this.Close();
        }

        /// <summary>
        /// Выход из этого окна
        /// </summary>
        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
