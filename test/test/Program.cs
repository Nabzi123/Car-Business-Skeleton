using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dataLocation1 = File.ReadAllLines("Location1.CSV");
            string[] dataLocation2 = File.ReadAllLines("Location2.CSV");
            List<Vehicles> Location1 = new List<Vehicles>();
            string[] bits;
            string Location = dataLocation1[0];
            for (int i = 1; i < dataLocation1.Length; i++)
            {
                bits = dataLocation1[i].Split(',');
                if(bits[0] == "Car")
                { 
                    Car c = new Car(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), double.Parse(bits[9]), bool.Parse(bits[10]));
                    Location1.Add(c);
                }
                

                if (bits[0] == "Plane")
                {
                    Plane p = new Plane(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                    Location1.Add(p);
                }

                if (bits[0] == "Helicopter")
                {
                    Helicopter h = new Helicopter(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                    Location1.Add(h);
                }

            }
            Console.ReadKey();







        }

    }
}
