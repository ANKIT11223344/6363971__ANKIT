using System;

namespace FactoryMethod
{
    public interface IVehicle
    {
        void Drive();
    }
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Car.");
        }
    }

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a Bike.");
        }
    }
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }
    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }

    public class BikeFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory;
            factory = new CarFactory();
            IVehicle car = factory.CreateVehicle();
            car.Drive();

            factory = new BikeFactory();
            IVehicle bike = factory.CreateVehicle();
            bike.Drive();
        }
    }
}