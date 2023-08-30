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


//WPF  - Windows Presentation Foundation фреймворк для создание масштабируемым графическим интрефесов
//MVC - model view controller что позволяет интерфейс и движок приложения разрабатывать разным людям, дизайнер 
//GUI - graphics user interface
//UX/UI user experiance design/ user interface графический интерфейс приложения записывается при помощи XAML
//XAML extensible application markup language(расширяемый язык разметки приложения)
//большинство дескрипторов HTML являються парными
//XML - xEntensible markup language
//HTML  Hyper-Text markup language

//если дескриптор не являеться контейнером не содержит другие элементы интерфейса, то его можно записать в сокращенном виде
// <descriptorName/> (каждый дескриптор описывает какой то  элемент окна)
namespace WPF
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
        bool running = false;
        private void btnStatus_Click(object sender, RoutedEventArgs e)
        {
            running = !running;
            if (running)
            {
                tbStatus.Text = "Running...";
                btnStatus.Content = "Stop";
            }
            else
            {
                tbStatus.Text = "Stopped";
                btnStatus.Content = "Run";
            }
            
        }
    }
}
