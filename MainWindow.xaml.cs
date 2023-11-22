using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfAppPopup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {

        private Popup confirmationPopup;
        public MainWindow()
        {
            InitializeComponent();
            InitializePopup();
        }

        private void InitializePopup()
        {
            confirmationPopup = new Popup();
            TextBlock popupText = new TextBlock
            {
                Text = "Заметка сохранена!",
                Background = System.Windows.Media.Brushes.LightGreen,
                Foreground = System.Windows.Media.Brushes.Black,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Padding = new Thickness(10),
                FontSize = 16
            };

            confirmationPopup.Child = popupText;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            confirmationPopup.IsOpen = true;
            System.Threading.Tasks.Task.Delay(2000).ContinueWith((t) =>
            {
                Dispatcher.Invoke(() => confirmationPopup.IsOpen = false);
            });
        }
    }
}



