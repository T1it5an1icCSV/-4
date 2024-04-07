using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
    public partial class TEST : Page
    {
        List<Question> que = new List<Question>();
        int i = 0;
        int correctAnswersCount = 0;
        public TEST()
        {
            InitializeComponent();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\Saved_test.json";
            que = SER_DES.Des<List<Question>>(path);
            LoadQuestion(0);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as PROHOD_TESTA).framee.Content = new RedTest();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void ans_first_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(Enum_for_right_answer.First, que[i].Right_Answer);
            i++;
            LoadQuestion(i);
        }

        private void ans_second_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(Enum_for_right_answer.Second, que[i].Right_Answer);
            i++;
            LoadQuestion(i);
        }

        private void ans_third_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(Enum_for_right_answer.Third, que[i].Right_Answer);
            i++;
            LoadQuestion(i);
        }
        private void LoadQuestion(int index)
        {
            if (index >= 0 && index < que.Count)
            {
                Question currentQuestion = que[index];
                Title.Text = currentQuestion.Title;
                Description.Text = currentQuestion.Description;
                first.Content = currentQuestion.Answer1;
                second.Content = currentQuestion.Answer2;
                third.Content = currentQuestion.Answer3;
            }
            else
            {
                Title.Text = "";
                Description.Text = "Правильных ответов: " + correctAnswersCount;
                first.Content = "";
                second.Content = "";
                third.Content = "";
                first.IsEnabled = false;
                second.IsEnabled = false;
                third.IsEnabled = false;
            }
        }
        private void CheckAnswer(Enum_for_right_answer selectedAnswer, Enum_for_right_answer correctAnswer)
        {
            if (selectedAnswer == correctAnswer)
            {
                correctAnswersCount++;
            }
        }
    }
}
