﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ClassesLibrary
{
    public class Vehicle
    {
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

        public Vehicle()
        {

        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Make: {0}\n" +
                "Model: {1}\n" +
                "Year: {2}\n" +
                "Weight: {3:f}lbs\n",
                Make, Model, Year, Weight);
        }

    }
}
