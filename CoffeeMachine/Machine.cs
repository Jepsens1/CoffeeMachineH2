using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    enum CoffeeBeans
    {
        Espresso,
        Christmas,
    }
    class Machine
    {
        //Properties
        //State to check if machine is on or off
        public bool State { get; set; }
        public CoffeeContainer Container { get; set; }
        public CoffeeBeans Beans { get; set; } = CoffeeBeans.Espresso;
        public void AddFilter()
        {
            //Simulate adding a filter
            Filter filter = new Filter();
        }
        public void FillContainer(int amount)
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
        public void MakeCoffee()
        {
            //Looks at which type of beans is used
            switch(Beans)
            {
                case CoffeeBeans.Christmas:
                    Container.Capacity -= 0.5;
                    break;
                case CoffeeBeans.Espresso:
                    Container.Capacity -= 0.7;
                    break;
            }
        }
        //Turns 
        public string TurnOn()
        {
            State = true;
            return "CoffeeMachine is now on";
        }
        public string TurnOff()
        {
            State = false;
            return "CoffeeMachine is now off";
        }
    }
}
