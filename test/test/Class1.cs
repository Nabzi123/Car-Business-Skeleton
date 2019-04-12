﻿using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Vehicles
    {
        protected string make;
        protected string model;
        protected int year;
        protected int price;
        protected int weight;
        protected string colour;
        protected string registration;

        public Vehicles(string make, string model, int year, int price, int weight, string colour, string registration)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.weight = weight;
            this.colour = colour;
            this.registration = registration;

        }

    }

    class Car : Vehicles
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
    }
}