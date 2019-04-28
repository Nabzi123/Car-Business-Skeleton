using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusinessSkeleton
{
    class VehiclesTemplate
    {
        protected string make;
        protected string model;
        protected int year;
        protected int price;
        protected int weight;
        protected string colour;
        protected string registration;

        public VehiclesTemplate(string make, string model, int year, int price, int weight, string colour, string registration)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.weight = weight;
            this.colour = colour;
            this.registration = registration;

        }

        public virtual void Restore()
        {
        }

    }

    class Car : VehiclesTemplate
    {
        int noOfDoors;
        double engineSize;
        bool electricWindows;

        public Car(string make, string model, int year, int price, int weight, string colour, string registration, int noOfDoors, double engineSize, bool electricWindows) : base(make, model, year, price, weight, colour, registration)
        {
            this.noOfDoors = noOfDoors;
            this.engineSize = engineSize;
            this.electricWindows = electricWindows;
        }

        public override void Restore()
        {
            weight = weight * (int)0.9;
            price = price * (int)1.25;

        }

        public override string ToString()
        {
            return GetType().ToString().Split('.')[1] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration + "," + noOfDoors + "," + engineSize + ","
                + electricWindows;
        }
    }

    class Plane : VehiclesTemplate
    {
        bool airWorthy;
        int hoursUsed;
        int altitudeLimit;
        int seats;
        string engines;

        public Plane(string make, string model, int year, int price, int weight, string colour, string registration, bool airWorthy, int hoursUsed, int altitudeLimit, int seats, string engines) : base(make, model, year, price, weight, colour, registration)
        {
            this.airWorthy = airWorthy;
            this.hoursUsed = hoursUsed;
            this.altitudeLimit = altitudeLimit;
            this.seats = seats;
            this.engines = engines;
        }

        public override string ToString()
        {
            return GetType().ToString().Split('.')[1] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration + "," + airWorthy + "," + hoursUsed + ","
                + altitudeLimit + "," + seats + "," + engines;
        }
    }

    class Helicopter : VehiclesTemplate
    {
        bool airWorthy;
        int hoursUsed;
        int altitudeLimit;


        public Helicopter(string make, string model, int year, int price, int weight, string colour, string registration, bool airWorthy, int hoursUsed, int altitudeLimit) : base(make, model, year, price, weight, colour, registration)
        {
            this.airWorthy = airWorthy;
            this.hoursUsed = hoursUsed;
            this.altitudeLimit = altitudeLimit;

        }

        public override string ToString()
        {
            return GetType().ToString().Split('.')[1] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration + "," + airWorthy + "," + hoursUsed + ","
                + altitudeLimit;
        }
    }

    class Truck : VehiclesTemplate
    {
        int weightLimit;
        int noOfWheels;
        int length;

        public Truck(string make, string model, int year, int price, int weight, string colour, string registration, int weightLimit, int noOfWheels, int length) : base(make, model, year, price, weight, colour, registration)
        {
            this.weightLimit = weightLimit;
            this.noOfWheels = noOfWheels;
            this.length = length;
        }

        public override string ToString()
        {
            return GetType().ToString().Split('.')[1] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration + "," + weightLimit + "," + noOfWheels + ","
                + length;
        }
    }
}

