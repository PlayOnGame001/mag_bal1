using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

namespace mag_bal1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] mas_answer;
        public MainWindow()
        {
            InitializeComponent();

            answer.IsEnabled = false;

            mas_answer = new string[] { "Решенно", "Повезло", "Таков Путь","Даааа",
            "поверь мне брат", "Я чувствую да","Вероятность не нижу 0","Шансы не плохие","Не ну тут да так да","Да",
            "Я думаю не, но попробуй снова","В комнате ожидание ответа", "Молчи", "Гадалка закрыта приходите позже","Я не чувствую от тебя жажды ответа",
            "Шансты стремяться к 0","Ноуп","Данные говорят что тебе пора прекратить спрашивать","Перспектив нету","Все плохо отмена код крастный" };
        }
        private void answer_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            answer.IsEnabled = false;
            Random random = new Random();
            textBlock.Text = mas_answer[random.Next(0, mas_answer.Length)];
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            answer.IsEnabled = true;
        }
    }
}
