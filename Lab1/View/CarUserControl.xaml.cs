using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Lab1.Enums;

namespace Lab1.View
{
    public partial class CarUserControl : UserControl
    {
        public string Model { get; set; }

        public CarBodyTypes Type { get; set; }

        public int MaxSpeed { get; set; }

        public Brush Color { get; set; }

        public CarUserControl()
        {
            InitializeComponent();
        }

        public CarUserControl(string model, CarBodyTypes type, int maxSpeed, Brush brush) : this()
        {
            Model = model;
            Type = type;
            MaxSpeed = maxSpeed;
            Color = brush;
        }
    }
}
