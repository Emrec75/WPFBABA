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

namespace Week_5_KeyDown
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

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 && e.KeyboardDevice.Modifiers == ModifierKeys.Shift
                || e.Key > Key.NumPad0 && e.Key <= Key.NumPad9
                || e.Key == Key.OemComma && e.KeyboardDevice.Modifiers == ModifierKeys.None)
            {
                lblResultaat.Content = "nummerieke waarde ingegeven ";
            }
            else
                e.Handled = true;

            
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            //converteer button
            Button btn = (Button)sender;

            MessageBox.Show($"Button {btn.Content.ToString()} clicked ");
            // MessageBox.Show("Button" + btn.Content.ToString() + "clicked" );
        }
    }
}
