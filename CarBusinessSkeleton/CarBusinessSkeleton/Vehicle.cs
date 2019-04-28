using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBusinessSkeleton
{
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();

            typeComboBox.Items.Add("Car");
            typeComboBox.Items.Add("Truck");
            typeComboBox.Items.Add("Plane");
            typeComboBox.Items.Add("Helicopter");

            ModelLabel.Hide();  //Hides the labels and text boxes for each label until a vehicle type is selected.
            modelTextBox.Hide();
            MakeLabel.Hide();
            makeTextBox.Hide();
            yearLabel.Hide();
            yearTextBox.Hide();
            priceLabel.Hide();
            priceTextBox.Hide();
            colourLabel.Hide();
            colourTextBox.Hide();
            registrationLabel.Hide();
            registrationLabel.Hide();
            weightLabel.Hide();
            weightTextBox.Hide();




            if ((string)typeComboBox.SelectedItem == "Car")
            {

            }
        }


    }
}
