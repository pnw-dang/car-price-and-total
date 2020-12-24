using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPriceAndTotal
{
    class Car
    {
        private string _make;
        private string _model;
        private int _mileage;
        private int _year;
        private double _price;
        private int _custID;
        private string _vin;

        public Car(string make, string model, int mileage, int year, double price, int custID, string vin)
        {
            _make = make;
            _model = model;
            _mileage = mileage;
            _year = year;
            _price = price;
            _custID = custID;
            _vin = vin;
        }

        public string Make { get { return _make; } }
        public string Model { get { return _model; } }
        public int Mileage { get { return _mileage; } }
        public int Year { get { return _year; } }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public int CustID { get { return _custID; } }
        public string Vin { get { return _vin; } }
    }
}
