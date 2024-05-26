using Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddOrders.xaml
    /// </summary>
    public partial class AddOrders : Window
    {
        private List<Service> _services; //список услуг
        private const string _jsonFilePath = "services.json"; //путь к файлу сохранения
        private List<Auto> _auto; //список авто
        private const string _jsonFilePath2 = "auto.json"; //путь к файлу сохранения

        internal event EventHandler<Order> OrdersAddEvent; //событие добавления объекта
        internal void OnOrdersAddEvent(Order orders) // OnOrdersAddEvent
        {
            OrdersAddEvent?.Invoke(this, orders);
        }

        public AddOrders(Window owner)
        {
            InitializeComponent();
            this.Owner = owner;
            _services = new List<Service>(); //инициализация списка услуг
            _services.Sort(); // сортировка интерфейс по условию icomporable
            ComboboxService.ItemsSource = _services; // заполнение обьектами
            _auto = new List<Auto>(); //инициализация списка услуг
            ComboboxAuto.ItemsSource = _auto; // заполнение обьектами
        }

        /// <summary>
        /// Добавление заказа в основное окно
        /// </summary>
        private void AddOrder(object sender, RoutedEventArgs e)
        {
            string classautofrombox = ComboboxAuto.Text.ToString();
            string service = ComboboxService.Text.ToString();
            var classauto = (Auto)ComboboxAuto.SelectedItem;
            string name = classauto.model;
            OnOrdersAddEvent(new Order(NameSurname.Text, DateTime.Text, service, name)); 
            MessageBox.Show("Заказ принят!");
            this.Close();
        }

        /// <summary>
        /// Выход из этого окна
        /// </summary>
        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #region работа с файлами json
        /// <summary>
        /// Загрузка из json и добавление обьектов в лист
        /// </summary>
        internal void LoadDataFromJson()
        {
            if (File.Exists(_jsonFilePath))
            {
                string serializationData = File.ReadAllText(_jsonFilePath); //считывание содержимого файла
                if (serializationData != null)
                {
                    var services = JsonConvert.DeserializeObject<List<Service>>(serializationData); //десериализация содержимого файла и запись в список задач
                    foreach (var service in services)
                    {
                        _services.Add(service);
                    }
                }

            }

            if (File.Exists(_jsonFilePath2))
            {
                string serializationData2 = File.ReadAllText(_jsonFilePath2); //считывание содержимого файла
                if (serializationData2 != null)
                {
                    var autos = JsonConvert.DeserializeObject<List<Auto>>(serializationData2); //десериализация содержимого файла и запись в список задач
                    foreach (var auto in autos)
                    {
                        _auto.Add(auto);
                    }
                }

            }
        }



        /// <summary>
        /// Загрузка в json и извлечение туда обьектов из листа
        /// </summary>
        internal void SaveDataToJson()
        {
            if (!File.Exists(_jsonFilePath))
            {
                File.Create(_jsonFilePath).Close();
            }
            string serializationData = JsonConvert.SerializeObject(_services);
            File.WriteAllText(_jsonFilePath, serializationData);

            if (!File.Exists(_jsonFilePath2))
            {
                File.Create(_jsonFilePath2).Close();
            }
            string serializationData2 = JsonConvert.SerializeObject(_auto);
            File.WriteAllText(_jsonFilePath2, serializationData2);
        }

        #endregion


        #region закрытие/загрузка окна
        /// <summary>
        /// Открытие и закрытие окна с логикой сохранения изменений и загрузки содержимого файлов json
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataFromJson();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveDataToJson();
        }
        #endregion
    }
}
