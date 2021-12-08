using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    class EspressoMachine : Machine
    {
        public override void AddFilter()
        {
            Filter filter = new Filter();
        }

        public override void FillContainer(int amount)
        {
            //Adds water to the container
            Container.Capacity += amount;
            //Checks to see if machine is full
            if (Container.Capacity > Container.MaxCapacity)
            {
                //Machine is already full
            }
            else
            {
                //Filled container
            }
        }

        public override void MakeDrink()
        {
            Container.Capacity -= 0.7;
        }
        public override string TurnOn()
        {
            State = true;
            return "EspressoMachine is now on";
        }
        public override string TurnOff()
        {
            State = false;
            return "EspressoMachine is now off";
        }
    }
}
