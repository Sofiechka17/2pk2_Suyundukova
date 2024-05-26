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
using Library;

namespace Суюндукова_София.WindowAppication
{
    /// <summary>
    /// Логика взаимодействия для AddOrders.xaml
    /// </summary>
    public partial class AddAuto : Window
    {
        internal event EventHandler<Auto> AddAutoEvent; //событие добавления объекта
        internal void OnAddAutoEvent(Auto auto) // OnAddAutoEvent
        {
            AddAutoEvent?.Invoke(this, auto);
        }

        public AddAuto(Window owner)
        {
            InitializeComponent();
            this.Owner = owner;
        }

        /// <summary>
        /// Кнопка добавление заказа
        /// </summary>
        private void AddNewAuto(object sender, RoutedEventArgs e)
        {
            string classauto = Combobox.Text.ToString();
            OnAddAutoEvent(new Auto(Model.Text, Condition.Text, classauto)); ;
            this.Close();
        }

        /// <summary>
        /// Просто выход
        /// </summary>
        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
