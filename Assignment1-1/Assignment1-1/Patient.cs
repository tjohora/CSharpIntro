using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_1
{
    class Patient
    {
        private String name;
        private double[] days = new double[5];

        public Patient(String name, double[] days) //ctor, 
        {
            this.name = name;
            this.days = days;
        }

        public String Name 
        {
            get { return name; }
            set { this.name = value; }
        } //prop, then hit tab x2
        public double[] Days { get; set; }

        public double calcAverage()
        {
            double total = 0;
            for (int i = 0; i <= 4; i++)
            {
                total += days[i];
            }
            return total / 5;
        }
        public String calcComment()
        {
            String comment = "";
            double average = calcAverage();
            if (average < 4)
            {
                comment = "Increase carbohydrate content";
            }
            else if (average > 6)
            {
                comment = "Decrease carbohydrate content";
            }
            else
            {
                comment = "Excellent";
            }
            return comment;
        }
        public override string ToString()
        {
            return String.Format("{0}\t\t| {1}\t| {2}\t| {3}\t| {4}\t| {5}\t| {6}\t| {7}", this.name, days[0], days[1], days[2], days[3], days[4], calcAverage(), calcComment());
        }


    }
}
