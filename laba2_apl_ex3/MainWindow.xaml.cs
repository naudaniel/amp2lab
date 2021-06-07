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

namespace laba2_apl_ex3
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

        private void log_button_Click(object sender, RoutedEventArgs e)
        {
            string username = user_log.Text;
            string password = pass_log.Password;
            if (username.Length <= 2)
            {
                none_log.Visibility = Visibility.Visible;
                none_pass.Visibility = Visibility.Hidden;
                
                img_err.Visibility = Visibility.Visible;
                img_done.Visibility = Visibility.Hidden;
            } else if (password.Length <= 2)
            {
                none_pass.Visibility = Visibility.Visible;
                none_log.Visibility = Visibility.Hidden;

                img_err.Visibility = Visibility.Visible;
                img_done.Visibility = Visibility.Hidden;
            } else
            {
                if (username == "admin")
                {
                    if (password == "admin")
                    {
                        img_done.Visibility = Visibility.Visible;
                        img_err.Visibility = Visibility.Hidden;
                    } else
                    {
                        img_err.Visibility = Visibility.Visible;
                        img_done.Visibility = Visibility.Hidden;
                    }
                }
                else
                {
                    img_err.Visibility = Visibility.Visible;
                    img_done.Visibility = Visibility.Hidden;
                }
            }
        }

        private void user_log_TextChanged(object sender, TextChangedEventArgs e)
        {
            img_done.Visibility = Visibility.Hidden;
            img_err.Visibility = Visibility.Hidden;

            none_log.Visibility = Visibility.Hidden;
            none_pass.Visibility = Visibility.Hidden;
        }

        private void pass_log_KeyDown(object sender, KeyEventArgs e)
        {
            none_log.Visibility = Visibility.Hidden;
            none_pass.Visibility = Visibility.Hidden;

            img_done.Visibility = Visibility.Hidden;
            img_err.Visibility = Visibility.Hidden;
        }
    }
}
