using System;

namespace Lab2.ViewModel
{
    public class Form
    {
        private Form()
        {
        }

        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public string SerialNumber { get; set; }

        public DateTime DateOfBirth { get; set; } = new DateTime(1990, 1, 1);

        public string Phone { get; set; }

        public string Country { get; set; }

        public Sex Sex { get; set; }

        private static Form _this;

        public static Form Object
        {
            get
            {
                if (_this == null)
                {
                    _this = new Form();
                }

                return _this;
            }
        }
    }

    public enum Sex
    {
        Male, Female
    }
}
