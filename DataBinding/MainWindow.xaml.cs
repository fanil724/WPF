using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            txtInput.Focus();
        }
        private string boundtext;

        public event PropertyChangedEventHandler PropertyChanged;

        public string BoundText
        {
            get { return boundtext; }
            set
            {
                boundtext = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Set from code";
        }
    }
}
