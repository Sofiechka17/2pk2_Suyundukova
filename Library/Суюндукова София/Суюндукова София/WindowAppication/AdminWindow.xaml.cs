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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private List<User> _users; //список пользователей
        private const string _jsonFilePath = "users.json"; //путь к файлу сохранения
        private List<Order> _orders; //список заказов
        private const string _jsonFilePath2 = "orders.json"; //путь к файлу сохранения
        public AdminWindow()
        {
            InitializeComponent();
            _users = new List<User>(); //инициализация списка услуг
            ListUsers.ItemsSource = _users; // заполнение обьектами
            _orders = new List<Order>(); //инициализация списка авто
            ListOrders.ItemsSource = _orders; // заполнение обьектами
            ListOrders.Items.Refresh();
            ListUsers.Items.Refresh();
        }
        /// <summary>
        /// Удаление пользователя
        /// </summary>
        private void Delete_Users(object sender, RoutedEventArgs e)
        {
            // Получаем выделенные элементы из ListBox
            var selectedItems = ListUsers.SelectedItems.Cast<User>().ToList();

            // Удаляем выделенные элементы из списка пользователей
            foreach (var item in selectedItems)
            {
                _users.Remove(item);
            }

            // Обновляем отображение ListBox
            ListUsers.ItemsSource = null;
            ListUsers.ItemsSource = _users;
        }

        /// <summary>
        /// Удаление заказов
        /// </summary>
        private void Delete_Orders(object sender, RoutedEventArgs e)
        {
            // Получаем выделенные элементы из ListBox
            var selectedItems = ListOrders.SelectedItems.Cast<Order>().ToList();

            // Удаляем выделенные элементы из списка заказов
            foreach (var item in selectedItems)
            {
                _orders.Remove(item);
            }

            // Обновляем отображение ListBox
            ListOrders.ItemsSource = null;
            ListOrders.ItemsSource = _orders;
        }

        /// <summary>
        /// Завершение работы
        /// </summary>
        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Переход ко 2 админ окну
        /// </summary>
        private void Next(object sender, RoutedEventArgs e)
        {
            ServicesAndAutos servicesAndAutos = new ServicesAndAutos();
            servicesAndAutos.Show();
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
                    var users = JsonConvert.DeserializeObject<List<User>>(serializationData); //десериализация содержимого файла и запись в список задач
                    foreach (var user in users)
                    {
                        _users.Add(user);
                    }
                }

            }

            if (File.Exists(_jsonFilePath2))
            {
                string serializationData2 = File.ReadAllText(_jsonFilePath2); //считывание содержимого файла
                if (serializationData2 != null)
                {
                    var orders = JsonConvert.DeserializeObject<List<Order>>(serializationData2); //десериализация содержимого файла и запись в список задач
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
            string serializationData = JsonConvert.SerializeObject(_users);
            File.WriteAllText(_jsonFilePath, serializationData);

            if (!File.Exists(_jsonFilePath2))
            {
                File.Create(_jsonFilePath2).Close();
            }
            string serializationData2 = JsonConvert.SerializeObject(_orders);
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
