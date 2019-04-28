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
            string[] vehicleData = File.ReadAllLines("Location1.CSV");
            List<VehiclesTemplate> vehicleList = new List<VehiclesTemplate>();
            string[] bits;
            for (int i = 1; i < vehicleData.Length; i++)
            {
                bits = vehicleData[i].Split(',');

                if (bits[0].ToUpper() == "Truck".ToUpper())
                {
                    Truck t = new Truck(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                    vehicleList.Add(t);
                }

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

                



            }
            /*Console.WriteLine(Location1[0].ToString());
            Location1[0].Restore();

            Console.WriteLine(Location1[0].ToString());
            Console.ReadKey();*/







        }

    }
}
