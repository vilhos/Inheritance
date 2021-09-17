using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike._model = "Kawasaki Z1";
            bike._maxSpeed = 215.5f;
            bike._weight = 450;
            bike.driverName = "Henry";
            bike.Race(bike.driverName);
            bike.Info();

            Plane plane = new Plane();
            plane._model = "Boing 747";
            plane._maxSpeed = 851.5f;
            plane._weight = 441000;
            plane.Fly("Ivan");
            plane.Info();

            Car car = new Car();
            car._model = "Toyota Camry";
            car._maxSpeed = 185;
            car._weight = 1600;
            car.Ride("Tom");
            car.Info();

            SuperCar superCar = new SuperCar();
            bike.driverName = "Garry";
            superCar.Drive(superCar.driverName, bike.driverName);
            float forsageSpeed = superCar.Forsage(car._maxSpeed);
            Console.WriteLine($"I have a surprise! Car speed will reach {forsageSpeed}");
            car.Info();

            Console.ReadLine();
        }
    }
    public class Vehicle
    {
        public string _model;
        public float _maxSpeed;
        public int _weight;
        private bool _isFuelFull = false;

        public Vehicle(string model, float maxSpeed, int vehicleWeight, bool isFuelFull)
        {
            _model = model;
            _maxSpeed = maxSpeed;
            _weight = vehicleWeight;
            _isFuelFull = isFuelFull;
            FuelCheck();
        }

        private void FuelCheck()
        {
            if (_isFuelFull)
                Console.WriteLine("Fuel is full.");

            else
                Console.WriteLine("Check fuel.");
        }

        public Vehicle(bool isFuelFull)
        {
            _isFuelFull = isFuelFull;
            FuelCheck();
        }

        public void Info()
        {
            Console.WriteLine($"Name {_model}, Speed {_maxSpeed}, Weight {_weight} isFuelFull {_isFuelFull}");
            Console.WriteLine("------------------------------------------------------");
        }
    }

    public class Bike : Vehicle
    {
        public string driverName;
        public Bike() : base(true)
        {

        }
        public void Race(string driverName)
        {
            Console.WriteLine($"Hi I'm {driverName}, I'm a biker and ready to race {_model}!");
        }
    }

    public class Plane : Vehicle
    {
        public Plane() : base(false)
        {

        }
        public void Fly(string driverName)
        {
            Console.WriteLine($"Hi I'm {driverName}, I'm your pilot, everyone have a nice flight with {_model}!");
        }
    }

    public class Car : Vehicle
    {
        public Car() : base("Toyota Camry", 185, 1600, true)
        {

        }

        public void Ride(string driverName)
        {
            Console.WriteLine($"Hi I'm {driverName}, I prefer a comfortable and safe ride with {_model}");
        }
    }

    public class SuperCar : Car
    {
        public SuperCar()
        {

        }
        public string driverName;
        float speedNitro = 1.5f;
        public void Drive(string driverName, string rivalName)
        {
            Console.WriteLine($"Hi I'm {driverName}, and I will win the race {rivalName} with my {_model}");
        }

        public float Forsage(float maxSpeed)
        {
            float forsageSpeed = speedNitro * maxSpeed;
            return forsageSpeed;
        }
    }
}
