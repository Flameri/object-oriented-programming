using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInheritance
{
    class Truck : Car
    {
        //fields
        protected double HaulWeight;
        protected double UsageKg;

        //constructor
        public Truck(string type, string model, int year, double price, double motorsize, string brand, int doors, double haulweight, double usagekg) : base(type, model, year, price, motorsize, brand, doors)
        {
            HaulWeight = haulweight;
            UsageKg = usagekg;
        }

        public string CalcCons()
        {
           double cons = HaulWeight / UsageKg;
            return ($"Kulutus on {cons} litraa");
        }
    }
}
