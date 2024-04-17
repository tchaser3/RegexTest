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
using System.Text.RegularExpressions;

namespace RegexTest
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string strTestingString;

            strTestingString = txtEnteredInformation.Text;

            string strMyTestPattern = @"^(\([0-9]{3}\)|[0-9]{3})[ -\.]?[0-9]{3}[ -\.]?[0-9]{4}$";

            bool TestingVar = Regex.IsMatch(strTestingString, strMyTestPattern);

            MessageBox.Show(Convert.ToString(TestingVar));

        }
    }
}
