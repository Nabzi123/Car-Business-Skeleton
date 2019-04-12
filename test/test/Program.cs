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
            string[] data = File.ReadAllLines("Location1.CSV");
            List<Vehicles> Location1 = new List<Vehicles>();
            string[] bits;
            string Location = data[0];
            for(int i = 1; i < data.Length; i++)
            {
                bits = data[i].Split(',');
                if(bits[0] == "Car")
                {
                    Car c = new Car(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), double.Parse(bits[9]), bool.Parse(bits[10]));
                    Location1.Add(c);
                }
            }
            Console.ReadKey();
        }
    }
}
