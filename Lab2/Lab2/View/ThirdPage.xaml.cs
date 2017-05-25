using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml;
using System.Xml.Serialization;
using Lab2.ViewModel;

namespace Lab2.View
{
    /// <summary>
    /// Interaction logic for ThirdPage.xaml
    /// </summary>
    public partial class ThirdPage : Page
    {
        public ThirdPage()
        {
            InitializeComponent();
            DataContext = Form.Object;
            CommandBinding bind = new CommandBinding(ApplicationCommands.Save);
            bind.Executed += Save_Executed;
            CommandBindings.Add(bind);
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Form.Object.Sex = MaleSex.IsChecked.Value ? Sex.Male : Sex.Female;
            XmlSerializer xsSubmit = new XmlSerializer(typeof(Form));
            var xml = string.Empty;

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, Form.Object);
                    xml = sww.ToString();
                    File.WriteAllText("foo.xml", xml);
                }
            }
        }
    }
}
