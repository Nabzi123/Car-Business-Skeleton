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
    public partial class Locations : Form
    {
        public Locations()
        {
            InitializeComponent();
            List<string> locationList = GetLocations();
            for (int i = 0; i < locationList.Count; i++)
            {
                locationsList.Items.Add(locationList[i]);
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

        private void selectLocation_Click(object sender, EventArgs e)
        {
            List<string> locationList = GetLocations();
            if ((string)locationsList.SelectedItem == locationList[0])
            {
                Form myForm = new Vehicles(locationList[0]);
                myForm.Show();
            }

            if ((string)locationsList.SelectedItem == locationList[1])
            {
                Form myForm = new Vehicles(locationList[1]);
                myForm.Show();
            }

            if ((string)locationsList.SelectedItem == locationList[2])
            {
                Form myForm = new Vehicles(locationList[2]);
                myForm.Show();
            }

            if ((string)locationsList.SelectedItem == locationList[3])
            {
                Form myForm = new Vehicles(locationList[3]);
                myForm.Show();
            }



        }

    }
}
