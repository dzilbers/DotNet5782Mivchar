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

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BtnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            ChkBoxApprove.IsChecked = !ChkBoxApprove.IsChecked;
            ((Button)sender).Background = new SolidColorBrush(Colors.Red);
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am here", "OK BUTTON", MessageBoxButton.OK);
        }

        private void BtnOK_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void ChkBoxApprove_Checked(object sender, RoutedEventArgs e)
        {
            BtnOK.IsEnabled = ((CheckBox)sender).IsChecked ?? false;
        }

        private void ChkBoxApprove_Unchecked(object sender, RoutedEventArgs e)
        {
            BtnOK.IsEnabled = ((CheckBox)sender).IsChecked ?? false;
            e.Handled = true;
        }

        static Random random = new();
        private void BtnCancel_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            Size size = (btn.Parent as Grid).RenderSize;
            Thickness margin = btn.Margin;
            margin.Left = random.NextDouble() * (size.Width - btn.ActualWidth);
            margin.Top = random.NextDouble() * (size.Height - btn.ActualHeight);
            btn.Margin = margin;
            
        }
    }
}
