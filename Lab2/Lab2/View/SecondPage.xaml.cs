using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab2.ViewModel;

namespace Lab2.View
{
    /// <summary>
    /// Interaction logic for SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
            DataContext = Form.Object;
            CommandBinding bind = new CommandBinding(NavigationCommands.GoToPage);
            bind.Executed += NextPage_Executed;
            CommandBindings.Add(bind);
        }

        private void NextPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            
            NavigationService nav = NavigationService.GetNavigationService(this);
            var nextPage = new ThirdPage();
            nav.Navigate(nextPage);
        }
    }
}
