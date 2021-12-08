using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    abstract class Machine
    {
        //Properties
        //State to check if machine is on or off
        public bool State { get; set; }
        public Container Container { get; set; }
        public abstract void AddFilter();
        public abstract void FillContainer(int amount);
        public abstract void MakeDrink();
        //Turns 
        public virtual string TurnOn()
        {
            State = true;
            return "CoffeeMachine is now on";
        }
        public virtual string TurnOff()
        {
            State = false;
            return "CoffeeMachine is now off";
        }
    }
}
