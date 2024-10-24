using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows;
using System.Windows.Controls;

namespace WpfApp7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateCloseButtonState();

            // Подписка на события изменения текста в текстовых полях
            TextBox1.TextChanged += (s, e) => UpdateCloseButtonState();
            TextBox2.TextChanged += (s, e) => UpdateCloseButtonState();
        }

        private void UpdateCloseButtonState()
        {
            CloseButton.IsEnabled = string.IsNullOrEmpty(TextBox1.Text) && string.IsNullOrEmpty(TextBox2.Text);
        }

        private void FontSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontSelector.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedFont = selectedItem.Content.ToString();
                TextBox1.FontFamily = new System.Windows.Media.FontFamily(selectedFont);
                TextBox2.FontFamily = new System.Windows.Media.FontFamily(selectedFont);
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
        }
    }
}



