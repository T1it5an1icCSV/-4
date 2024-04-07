using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class RedTest : Page
    {
        List<Question> que = new List<Question>();
        public RedTest()
        {
            InitializeComponent();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\Saved_test.json";
            que = SER_DES.Des<List<Question>>(path);
            dataGrid.ItemsSource = que;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Question selectedQue = dataGrid.SelectedItem as Question;

        }

        private void ADD_Button_Click(object sender, RoutedEventArgs e)
        {
            que.Add(new Question("", "", "", "", "", Enum_for_right_answer.First));
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = que;
        }

        private void SAVE_Button_Click(object sender, RoutedEventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\Saved_test.json";
            SER_DES.Ser<List<Question>>(que, path);
        }
    }
}
