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

namespace laba2_apl_ex2
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
        private void btnOperator(object sender, RoutedEventArgs e)
        {

            // get the two numbers
            double n1 = GetNumber(this.txtNumber1);
            if (n1 == 0) { return; }

            double n2 = GetNumber(this.txtNumber2);
            if (n2 == 0) { return; }

            // now get the button which made this happen
            Button btn = sender as Button;

            // button names are btnAdd, btnSubtract, etc.
            string buttonOperator = btn.Name.Substring(3).ToLower();

            // calculate appropriate value
            double answer = 0;
            switch (buttonOperator)
            {
                case "add":
                    answer = n1 + n2;
                    break;
                case "subtract":
                    answer = n1 - n2;
                    break;
                case "multiply":
                    answer = n1 * n2;
                    break;
                case "divide":
                    answer = n1 / n2;
                    break;
                case "root":
                    answer = Math.Pow(n1, (1 / n2));
                    break;
                case "step":
                    answer = Math.Pow(n1, n2);
                    break;
                case "log":
                    answer = Math.Log(n1, n2);
                    break;
                case "mod":
                    answer = n1 % n2;
                    break;
            }

            lblAnswer.Content = "Відповідь " + answer.ToString("#,##0.00");
            lblAnswer.Visibility = Visibility.Visible;
        }

        // this would be better done using a readonly property, but this is a bit advanced - for now,
        // create a routine to return a number given a textbox
        private double GetNumber(TextBox txt)
        {

            double thisNumber;

            // if text box blank, return zero
            if (txt.Text.Trim().Length == 0) { thisNumber = 0; }

            // try to convert to double - return - otherwise
            try
            {
                return Convert.ToDouble(txt.Text);
            }
            catch
            {
                thisNumber = 0;
            }

            // if the number isn't set, display error message
            if (thisNumber == 0)
            {
                MessageBox.Show("Введіть число", "Error");
                txt.Focus();
                return 0;
            }
            else
            {
                return thisNumber;
            }
        }
    }
}
