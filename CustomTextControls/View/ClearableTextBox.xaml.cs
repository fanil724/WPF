using System.Windows;
using System.Windows.Controls;

namespace CustomTextControls.View
{
    /// <summary>
    /// Interaction logic for ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }
        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set
            {
                placeholder = value;
                tbPlaceHolder.Text = placeholder;
            }
        }


        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (string.IsNullOrEmpty(txtInput.Text))         
            //    tbPlaceHolder.Visibility = Visibility.Visible;            
            //else           
            //    tbPlaceHolder.Visibility = Visibility.Hidden;

            tbPlaceHolder.Visibility = string.IsNullOrEmpty(txtInput.Text) ? Visibility.Visible : Visibility.Hidden;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }
    }
}
