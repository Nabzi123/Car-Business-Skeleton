using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarBusinessSkeleton
{
    public partial class Vehicles : Form
    {
        string currentLocation;
        static List<VehiclesTemplate> vehicleList;
        static List<string> locationList;

        public Vehicles(string Location)
        {
            InitializeComponent();
            locationList = GetLocations();
            if (Location == locationList[0])
            {
                currentLocation = locationList[0];
                string fileName = "Location1.CSV";
                vehicleList = GetVehicles(fileName);

                for (int i = 0; i < vehicleList.Count; i++)
                {
                    vehiclesListBox.Items.Add(vehicleList[i]);
                }

            }

            if (Location == locationList[1])
            {
                string fileName = "Location2.CSV";
                vehicleList = GetVehicles(fileName);

                for (int i = 0; i < vehicleList.Count; i++)
                {
                    vehiclesListBox.Items.Add(vehicleList[i]);
                }

            }

            if (Location == locationList[2])
            {
                string fileName = "Location3.CSV";
                vehicleList = GetVehicles(fileName);

                for (int i = 0; i < vehicleList.Count; i++)
                {
                    vehiclesListBox.Items.Add(vehicleList[i]);
                }

            }

            if (Location == locationList[3])
            {
                string fileName = "Location4.CSV";
                vehicleList = GetVehicles(fileName);

                for (int i = 0; i < vehicleList.Count; i++)
                {
                    vehiclesListBox.Items.Add(vehicleList[i]);
                }

            }

        }

        public List<string> GetLocations()
        {
            List<string> vehicleLocations = new List<string>();
            string[] Location1 = File.ReadAllLines("Location1.CSV");
            string[] Location2 = File.ReadAllLines("Location2.CSV");
            string[] Location3 = File.ReadAllLines("Location3.CSV");
            string[] Location4 = File.ReadAllLines("Location4.CSV");

            vehicleLocations.Add(Location1[0]);
            vehicleLocations.Add(Location2[0]);
            vehicleLocations.Add(Location3[0]);
            vehicleLocations.Add(Location4[0]);

            return vehicleLocations;
        }

        static List<VehiclesTemplate> GetVehicles(string pFileName)
        {
            string[] vehicleData = File.ReadAllLines(pFileName);
            List<VehiclesTemplate> vehicleList = new List<VehiclesTemplate>();
            string[] bits;
            for (int i = 1; i < vehicleData.Length; i++)
            {
                bits = vehicleData[i].Split(',');

                if (bits[0].ToUpper() == "Car".ToUpper())
                {
                    Car c = new Car(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), double.Parse(bits[9]), bool.Parse(bits[10]));
                    vehicleList.Add(c);
                }


                if (bits[0].ToUpper() == "Plane".ToUpper())
                {
                    Plane p = new Plane(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                    vehicleList.Add(p);
                }

                if (bits[0].ToUpper() == "Helicopter".ToUpper())
                {
                    Helicopter h = new Helicopter(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                    vehicleList.Add(h);
                }

                if (bits[0].ToUpper() == "Truck".ToUpper())
                {
                    Truck t = new Truck(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                    vehicleList.Add(t);
                }

                

            }

            return vehicleList;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form myform = new Vehicle();
            myform.Show();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            Form myform = new Vehicle();
            myform.Show();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            vehiclesListBox.Items.Remove(vehiclesListBox.SelectedItem);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (currentLocation == locationList[0])
            {
                File.Create("Location1.CSV").Close();
                StreamWriter sw = new StreamWriter("Location1.CSV");
                sw.WriteLine("London");
                for (int i = 0; i < vehiclesListBox.Items.Count; i++)
                {
                    sw.WriteLine(vehiclesListBox.Items[i].ToString());

                }
                sw.Flush();
                sw.Close();
                this.Close();
            }
            

        }
    }
}
