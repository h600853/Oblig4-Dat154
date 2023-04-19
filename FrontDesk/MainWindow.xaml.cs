using System.Windows;
using System.Windows.Controls;

namespace FrontDesk
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /**
            Editor ed = new(dx)
            {
                dx = dx;
            };

        editor.Show();
            **/

        }

        public void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Your event handling code here
        }



    }
}
