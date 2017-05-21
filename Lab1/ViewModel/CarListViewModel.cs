using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1.ViewModel
{
    public class CarListViewModel
    {
        public CarListViewModel()
        {
            Items.Add(new View.CarUserControl());
            Items.Add(new View.CarUserControl());
            Items.Add(new View.CarUserControl());
            Items.Add(new View.CarUserControl());
            Items.Add(new View.CarUserControl());
            Items.Add(new View.CarUserControl());
            Items.Add(new View.CarUserControl());
        }

        public List<View.CarUserControl> Items { get; set; } = new List<View.CarUserControl>(); 
    }
}
