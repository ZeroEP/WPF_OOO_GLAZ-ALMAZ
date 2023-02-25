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
using WPF_OOO_GLAZ_ALMAZ.Entitys;

namespace WPF_OOO_GLAZ_ALMAZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Auth_click(object sender, RoutedEventArgs e)
        {
            if (login_tb.Text != "" && password_tb.Password != "")
            {
                User user = EfModel.Init().Users.FirstOrDefault(x => x.UserLogin == login_tb.Text && x.UserPassword == password_tb.Password);
                if (user != null)
                {
                    MessageBox.Show("Приветствую " + user.UserLogin + "");
                    SypplyWindow window = new SypplyWindow();
                    this.Close();
                    window.Show();
                }
                else
                    MessageBox.Show("Неправильный логин или пароль");
            }
            else
                MessageBox.Show("Введите значение");
        }
    }
}
