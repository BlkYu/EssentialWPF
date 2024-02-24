using System.Windows;

namespace Chapter1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MyWindow : Window
    {
        public MyWindow()
        {
            InitializeComponent();
        }

        void HowdyClicked(object sender, RoutedEventArgs e) 
        {
            _text1.Text = "C#からこんにちは！";
        }
    }
}