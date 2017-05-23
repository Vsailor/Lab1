using System.Windows;
using System.Windows.Media.Imaging;

namespace Lab1.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CarListUserControl _carListUserControl = new CarListUserControl();
        private AddCarUserControl _addCarUserControl;
        public MainWindow()
        {
            InitializeComponent();
            CommonGrid.Children.Add(_carListUserControl);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            _addCarUserControl = new AddCarUserControl();
            CommonGrid.Children.Clear();
            CommonGrid.Children.Add(_addCarUserControl);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (_addCarUserControl == null || string.IsNullOrEmpty(_addCarUserControl.Model))
            {
                return;    
            }

            _carListUserControl.AddCar(
                _addCarUserControl.Model,
                _addCarUserControl.SelectedBodyType,
                _addCarUserControl.MaxSpeed,
                _addCarUserControl.SelectedColor);

            CommonGrid.Children.Clear();
            CommonGrid.Children.Add(_carListUserControl);
            _addCarUserControl = null;
        }
    }
}
