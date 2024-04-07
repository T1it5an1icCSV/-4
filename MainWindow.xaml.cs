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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\Saved_test.json";
            if (!File.Exists(path))
            {
                List<Question> que = new List<Question>();
                SER_DES.Ser<List<Question>>(que, path);
            }
        }

        private void Proiti_Button_Click(object sender, RoutedEventArgs e)
        {
            PROHOD_TESTA wind = new PROHOD_TESTA();
            wind.Show();
            wind.Red.IsEnabled = false;
            Close();
        }

        private void Redactirovat_FREE_TEXT_Button_Click(object sender, RoutedEventArgs e)
        {
            FREE_TEXT.IsEnabled = true;
        }

        private void CheckPassword()
        {
            if (FREE_TEXT.Text == "редактор")
            {
                OpenNewWindow();
            }
        }
        private void OpenNewWindow()
        {
            PROHOD_TESTA wind = new PROHOD_TESTA();
            wind.Show();
            Close();
        }

        private void FREE_TEXT_Changed(object sender, TextChangedEventArgs e)
        {
            if (FREE_TEXT.Text != "")
            {
                CheckPassword();
            }
        }
    }
}
