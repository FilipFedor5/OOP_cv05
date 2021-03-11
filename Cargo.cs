using System;
using System.Collections.Generic;
using System.Text;

namespace cv5
{
    public class Cargo : Car
    {
        
      private double loadedCargo;

       public double MaxCargo
        { get; protected set ; }
        

        public double LoadedCargo
        {
            get { return loadedCargo; }
            set
            {
                if (value > MaxCargo) throw new Exception("You cannot load that much cargo");
                loadedCargo = value;
            }
        }

        public Cargo (double maxCargo, Fuel fuel, double tankVolume) : base(tankVolume, fuel)
        {
            MaxCargo= maxCargo;
            LoadedCargo = 0;
        }
        public override string ToString()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("Passenger car \n");
            buffer.Append("Tank volume: ");
            buffer.Append(TankVolume);
            buffer.Append("\nFuel inside tank ");
            buffer.Append(this.TankStatus);
            buffer.Append(" liters\nCargo ");
            buffer.Append(LoadedCargo);
            buffer.Append(" of ");
            buffer.Append(MaxCargo);
            buffer.Append(" maximum cargo");

            return (buffer.ToString());
        }

    }
}
