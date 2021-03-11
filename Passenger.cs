using System;
using System.Collections.Generic;
using System.Text;

namespace cv5
{
    public class Passenger : Car 
    {
        private int maxPassengers;
        private int loadedPassengers;

        public int MaxPassengers
        {get; protected set;}

        public int LoadedPassenges
        {
            get { return loadedPassengers; }
            set
            {
                if (value > MaxPassengers) throw new Exception("You cannot load that much passengers");
                loadedPassengers = value;
            }
        }

        public Passenger(int maxPassengers, Fuel fuel, double tankVolume) :base(tankVolume, fuel)
        {
            this.maxPassengers = maxPassengers;
            loadedPassengers = 0;
        }

        public override string ToString()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("Passenger car \n");
            buffer.Append("Tank volume: ");
            buffer.Append(TankVolume);
            buffer.Append("\nFuel inside tank ");
            buffer.Append(this.TankStatus);
            buffer.Append(" liters\nPassengers: ");
            buffer.Append(loadedPassengers);
            buffer.Append(" of ");
            buffer.Append(MaxPassengers);
            

            return (buffer.ToString());
        }
    }
}
