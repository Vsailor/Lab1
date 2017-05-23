using System.Windows.Controls;
using System.Windows.Media;
using Lab1.Enums;
using Lab1.ViewModel;

namespace Lab1.View
{
    public partial class CarListUserControl : UserControl
    {
        private readonly CarListViewModel _carListViewModel = new CarListViewModel();

        public CarListUserControl()
        {
            InitializeComponent();
            DataContext = _carListViewModel;
        }

        public void AddCar(string model, CarBodyTypes type, int maxSpeed, Brush brush)
        {
            _carListViewModel.Items.Add(new CarUserControl(model, type, maxSpeed, brush));
            DataContext = null;
            DataContext = _carListViewModel;
        }
    }
}
