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
    /// Логика взаимодействия для OrdersWindow.xaml
    /// </summary>
    public partial class OrdersWindow : Window
    {
        private List<Order> _orders; //список пользователей
        private const string _jsonFilePath = "orders.json"; //путь к файлу сохранения
        public OrdersWindow()
        {
            InitializeComponent();
            _orders = new List<Order>(); //инициализация списка пользователей
        }

        /// <summary>
        /// Добавление заказа, обмен данных через событие
        /// </summary>
        private void AddOrder(object sender, RoutedEventArgs e)
        {
            AddOrders addOrders = new AddOrders(this); //создание окна для добавления заказа
            addOrders.Show(); //отображение окна

            //подписка на событие добавления заказов в дочернем окне
            addOrders.OrdersAddEvent += delegate (object senser, Order orders)
            {
                _orders.Add(orders);
            };
        }

        /// <summary>
        /// Возращаемся в основное окно
        /// </summary>
        private void Button_Main(object sender, RoutedEventArgs e)
        {
            MainWindowLK mainWindow = new MainWindowLK();
            mainWindow.Show();
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
                    var orders = JsonConvert.DeserializeObject<List<Library.Order>>(serializationData); //десериализация содержимого файла и запись в список задач
                    foreach (var order in orders)
                    {
                        _orders.Add(order);
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
            string serializationData = JsonConvert.SerializeObject(_orders);
            File.WriteAllText(_jsonFilePath, serializationData);
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
