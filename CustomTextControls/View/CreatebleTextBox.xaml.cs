using System.Windows;
using System.Windows.Controls;

namespace CustomTextControls.View
{
    /// <summary>
    /// Interaction logic for CreatebleTextBox.xaml
    /// </summary>
    public partial class CreatebleTextBox : UserControl
    {
        public CreatebleTextBox()
        {
            InitializeComponent();
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
