using System;

namespace cv5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cargo cargoCar = new Cargo(10, Car.Fuel.diesel, 50);
            cargoCar.Refuel(cargoCar.TankVolume,Car.Fuel.diesel);
            Console.WriteLine(cargoCar.ToString());


            Passenger passengerCar = new Passenger(5, Car.Fuel.petrol, 20);

            Console.WriteLine(passengerCar.ToString());

            passengerCar.TurnRadioOn();
            Console.WriteLine(passengerCar.RadioStatus());
        }
    }
}
