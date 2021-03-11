using System;
using System.Collections.Generic;
using System.Text;

namespace cv5
{
    abstract public class Car
    {
        public enum Fuel
        {
            diesel,
            petrol
        }

       
        public double TankStatus { get; protected set; }
        public Fuel fuelType { get; protected set; }

        private CarRadio radio = new CarRadio();

        public double TankVolume { get; protected set; }//sets these values to readonly from outside, can be changed only by method Refuel, TankVolume is only created by instance construktor
        

        public Car(double tankVolume, Fuel fuelType)
        {
            TankVolume = tankVolume;
            this.fuelType = fuelType;
            TankStatus = 0;
        }
        public void ReFuel(double fillVolume,Fuel refilledFuel)
        {
            if (refilledFuel != fuelType) throw new Exception("Wrong fuel type");

            if (TankStatus + fillVolume > TankVolume) throw new Exception("Can't fill too much volume of fuel, tank would overflow");

            TankStatus =+ fillVolume;
        }

        public void SetPreset(double frequency, int presetNumber)
        {
            radio.SetPreset(frequency, presetNumber);
        }

        public void TunePreset(int preset)
        {
            radio.TunePreset(preset);
        }
        public void TurnRadioOn()
        {
            radio.TurnOn();
        }
        public void TurnRadioOff()
        {
            radio.TurnOff();
        }

        public string RadioStatus()
        {
            return radio.Tostring();
        }

    }
}
