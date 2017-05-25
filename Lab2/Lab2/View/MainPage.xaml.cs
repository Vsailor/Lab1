using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using Lab2.ViewModel;

namespace Lab2.View
{
    public partial class MainPage : Page
    {
        public MainPage()
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
            var nextPage = new SecondPage();
            nav.Navigate(nextPage);
        }
    }
}
