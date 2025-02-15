using ShopManagement.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Cryptography;

namespace ShopManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginPage CurrentLoginPage;
        public MainWindow()
        {
            InitializeComponent();
            CurrentLoginPage = new LoginPage();
            CurrentLoginPage.LoginButton.Click += LoginButton_Click;
            MainGrid.Children.Add(CurrentLoginPage);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string Login = CurrentLoginPage.LoginInput.Text;
            SHA256 Converter = SHA256.Create();
            byte[] PasswordBytes = Converter.ComputeHash(Encoding.UTF8.GetBytes(CurrentLoginPage.PasswordInput.Password));
            StringBuilder PassBuilder = new StringBuilder();
            foreach (byte Byte in PasswordBytes)
            {
                PassBuilder.Append(Byte.ToString());
            }
            string Password = PassBuilder.ToString();
            Dbuser UserData = ShopManagementContext.DB.Dbusers.FirstOrDefault(U => U.UserLogin == Login);
            if (UserData != null)
            {
                if (UserData.UserPassword == Password)
                {
                    MainGrid.Children.Remove(CurrentLoginPage);
                    ProductsTable.ItemsSource = ShopManagementContext.DB.Products.ToList();
                }
                else
                {
                    MessageBox.Show("Неверный Пароль!");
                }
            }
            else
            {
                MessageBox.Show("Такого Логина Нет!");
            }
        }
    }
}