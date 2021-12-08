using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    class CoffeeContainer
    {
        //Properties
        public double MaxCapacity { get; set; } = 2;
        public double Capacity { get; set; }

        //Constructor
        public CoffeeContainer(double capacity, double maxcapacity)
        {
            Capacity = capacity;
            MaxCapacity = maxcapacity;
        }
    }
}
