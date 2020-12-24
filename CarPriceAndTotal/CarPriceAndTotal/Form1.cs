using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarPriceAndTotal
{
    public partial class CarPriceUpdate : Form
    {
        List<Car> CarList = new List<Car>();
        Random rand = new Random();
        public CarPriceUpdate()
        {
            InitializeComponent();
            PreloadCarList();
            Display(CarList);
        }
        private void PreloadCarList(int numOfCars = 10)
        {
            rand = new Random();
            string[] makes = { "Ford", "Honda", "Toyota", "Nissan" };
            string[] fordModels = { "Focus", "Explorer", "Mustang", "Taurus", "Fiesta" };
            string[] hondaModels = { "Civic Sedan", "Civic Coupe", "Accord Sedan", "CR_Z", "Element" };
            string[] toyotaModels = { "Corolla", "Camry", "Matrix", "Avalon", "Tundra" };
            string[] nissanModels = { "Altima", "Maxima", "Murano", "370Z", "Pathfinder", "Quest", "Sentra" };

            string[] fordVin = { "1FB", "1FC", "2FA", "2FB", "VS6", "MRO", "VSE" };
            string[] hondaVin = { "1H", "2HG", "2HK", "SHS", "MA7", "JHM", "JHG" };
            string[] toyotaVin = { "JT", "LVT", "5T" };
            string[] nissanVin = { "JN", "VSK", "5N1" };

            int Year = rand.Next(2004, 2019);
            decimal Price = rand.Next(5000, 24000);
            int CustID = rand.Next(12345678, 99999999);

            for (int i = 0; i < numOfCars; i++)
            {
                string make = makes[rand.Next(makes.Length)];
                string model;
                string vin;
                int mileage = rand.Next(1, 20000);
                int year = rand.Next(1995, 2020);
                double price = rand.Next(500, 100000) + rand.NextDouble();
                int custID = rand.Next(100000000, 999999999);

                switch (make)
                {
                    case "Ford":
                        model = fordModels[(rand.Next(fordModels.Length))];
                        vin = fordVin[rand.Next(fordVin.Length)];
                        break;
                    case "Honda":
                        model = hondaModels[(rand.Next(hondaModels.Length))];
                        vin = hondaVin[rand.Next(hondaVin.Length)];
                        break;
                    case "Toyota":
                        model = toyotaModels[(rand.Next(toyotaModels.Length))];
                        vin = toyotaVin[rand.Next(toyotaVin.Length)];
                        break;
                    case "Nissan":
                        model = nissanModels[(rand.Next(nissanModels.Length))];
                        vin = nissanVin[rand.Next(nissanVin.Length)];
                        break;
                    default:
                        model = "";
                        vin = "";
                        break;
                }

                CarList.Add(new Car(make, model, mileage, year, price, custID, vin));
            }
        }
        private void Display(List<Car> Automobiles)
        {
            displayInfoLV.Items.Clear();
            foreach (Car vehicle in Automobiles)
            {
                string[] vehicleList = {vehicle.Make, vehicle.Model, vehicle.Mileage.ToString(), vehicle.Year.ToString(), vehicle.Price.ToString("c"),
                vehicle.CustID.ToString(), vehicle.Vin};
                ListViewItem LVItems = new ListViewItem(vehicleList);
                displayInfoLV.Items.Add(LVItems);
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (displayInfoLV.SelectedIndices.Count > 0)
            {
                int index = displayInfoLV.SelectedIndices[0];
                Car SelectedCar = CarList[index];

                double newPrice;
                if (double.TryParse(updateTxtBox.Text, out newPrice))
                {
                    SelectedCar.Price = newPrice;
                    Display(CarList);
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }
        private void totalBtn_Click(object sender, EventArgs e)
        {
            double total = GetTotalValue(CarList);
            MessageBox.Show($"The total value is: {total.ToString("c")}");
        }
        private double GetTotalValue(List<Car> list)
        {
            double sum = 0;

            foreach (Car car in list)
            {
                sum += car.Price;
            }
            return sum;
        }
    }
}
