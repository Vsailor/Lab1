using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using Lab1.Enums;

namespace Lab1.View
{
    public partial class AddCarUserControl : UserControl
    {
        public List<Brush> ColorsList { get; set; }

        public Brush SelectedColor { get; set; } = Brushes.Red;

        public List<CarBodyTypes> BodyTypes { get; set; } 

        public CarBodyTypes SelectedBodyType { get; set; } = CarBodyTypes.Hatchback;

        public string Model { get; set; }

        public int MaxSpeed { get; set; }

        public AddCarUserControl()
        {
            InitializeComponent();
            ColorsList = new List<Brush>
            {
                Brushes.Red,
                Brushes.Blue,
                Brushes.Yellow,
                Brushes.Green,
                Brushes.White
            };

            BodyTypes = Enum.GetValues(typeof(CarBodyTypes)).Cast<CarBodyTypes>().ToList();
            DataContext = this;
        }
    }
}
