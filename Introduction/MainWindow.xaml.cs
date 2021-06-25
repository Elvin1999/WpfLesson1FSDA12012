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

namespace Introduction
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

        private void mybtn_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Hi Wpf","C# Language", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                MyGrid.Background = Brushes.LightCoral;
            }
        }
        int clickCount = 0;
        private void mybtn2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ++clickCount;
            //mybtn2.Content = clickCount;
           // mystackpanel.Orientation = Orientation.Horizontal;
        }

        private void mybtn2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void mybtn2_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
