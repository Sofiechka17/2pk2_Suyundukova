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
using Library;
using Суюндукова_София.WindowAppication;

namespace Суюндукова_София.Reg_and_Auth
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        private List<User> _users; //список пользователей
        private const string _jsonFilePath = "users.json"; //путь к файлу сохранения
        public RegWindow()
        {
            InitializeComponent();
            _users = new List<User>(); //инициализация списка пользователей
        }

        private void Registration(object sender, RoutedEventArgs e)
        {
            _users.Add(new User(Name.Text + " " + Surname.Text, Login.Text, Password.Password));
            MainWindowLK mainWindow = new MainWindowLK();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Autorization(object sender, RoutedEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            auth.Show();
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
