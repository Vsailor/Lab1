using System.Windows.Controls;
using Lab1.ViewModel;

namespace Lab1.View
{
    /// <summary>
    /// Interaction logic for CarListUserControl.xaml
    /// </summary>
    public partial class CarListUserControl : UserControl
    {
        public CarListUserControl()
        {
            InitializeComponent();
            DataContext = new CarListViewModel();
        }
    }
}
