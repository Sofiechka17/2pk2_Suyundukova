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
    /// Логика взаимодействия для Services.xaml
    /// </summary>
    public partial class ServicesAndAutos : Window
    {
        private List<Service> _services; //список услуг
        private const string _jsonFilePath = "services.json"; //путь к файлу сохранения
        private List<Auto> _auto; //список авто
        private const string _jsonFilePath2 = "auto.json"; //путь к файлу сохранения
        public ServicesAndAutos()
        {
            InitializeComponent();
            _services = new List<Service>(); //инициализация списка услуг
            ListService.ItemsSource = _services; // заполнение обьектами
            _auto = new List<Auto>(); //инициализация списка авто
            Autos.ItemsSource = _auto; // заполнение обьектами
        }

        /// <summary>
        /// Добавление услуги
        /// </summary>
        private void AddService(object sender, RoutedEventArgs e)
        {
            AddServices addService = new AddServices(this); //создание окна для добавления заметки
            addService.Show(); //отображение окна

            //подписка на событие добавления заказов в дочернем окне
            addService.ServicesAddEvent += delegate (object senser, Service service)
            {
                _services.Add(service);
                _services.Sort(); // сортировка интерфейс по условию icomporable
                ListService.Items.Refresh(); //обновления списка в окне 
            };
        }

        /// <summary>
        /// Добавление авто
        /// </summary>
        private void AddAuto(object sender, RoutedEventArgs e)
        {
            AddAuto addAuto = new AddAuto(this); //создание окна для добавления заметки
            addAuto.Show(); //отображение окна

            //подписка на событие добавления заказов в дочернем окне
            addAuto.AddAutoEvent += delegate (object senser,Auto auto)
            {
                _auto.Add(auto);
                Autos.Items.Refresh(); //обновления списка в окне 
            };
        }

        /// <summary>
        /// Удаление услуги
        /// </summary>
        private void Delete_Service(object sender, RoutedEventArgs e)
        {
            // Получаем выделенные элементы из ListBox
            var selectedItems = ListService.SelectedItems.Cast<Service>().ToList();

            // Удаляем выделенные элементы из списка заказов
            foreach (var item in selectedItems)
            {
                _services.Remove(item);
            }

            // Обновляем отображение ListBox
            ListService.ItemsSource = null;
            ListService.ItemsSource = _services;
        }

        /// <summary>
        /// Удаление авто
        /// </summary>
        private void Delete_Auto(object sender, RoutedEventArgs e)
        {
            // Получаем выделенные элементы из ListBox
            var selectedItems = Autos.SelectedItems.Cast<Auto>().ToList();

            // Удаляем выделенные элементы из списка заказов
            foreach (var item in selectedItems)
            {
                _auto.Remove(item);
            }

            // Обновляем отображение ListBox
            Autos.ItemsSource = null;
            Autos.ItemsSource = _auto;
        }

        /// <summary>
        /// Завершение работы
        /// </summary>
        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Возращение к старому окну
        /// </summary>
        private void Back(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
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
