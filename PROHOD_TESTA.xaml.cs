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
using WpfApp7;

namespace WpfApp7;
public partial class PROHOD_TESTA : Window
{
        public PROHOD_TESTA()
        {
            InitializeComponent();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\Saved_test.json";
            if (!Pust(path))
            {
                framee.Content = new NO_TEST();
            }
        }
        private void PROHOD_Button_Click(object sender, RoutedEventArgs e)
        {
            framee.Content = new TEST();
        }

        private void RED_Button_Click(object sender, RoutedEventArgs e)
        {
            framee.Content = new RedTest();
        }

        private void EXIT_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
        private bool Pust(string path)
        {
            List<Question> dataList = SER_DES.Des<List<Question>>(path);
            if (dataList == null || dataList.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

