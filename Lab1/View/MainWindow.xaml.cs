using System.Windows;

namespace Lab1.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            CommonGrid.Children.Add(new CarListUserControl());
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            CommonGrid.Children.Clear();
            CommonGrid.Children.Add(new AddCarUserControl());
        }
    }
}
