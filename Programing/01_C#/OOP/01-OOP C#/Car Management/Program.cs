/*
Car Management
Required:
Create a class named Car.
The class has the following properties: Model, Speed, FuelLevel.

Make the properties private, and use methods to control:
Accelerate.
Decelerate.
Check fuel level.
Refill fuel.
 */
namespace Car_Management
{
    class Car
    {
        private string model;
        private int speed;
        private int fuelLevel;

        public void PrintInfoModel()
        {
            Console.WriteLine($"\nModel : {Model}");
            Console.WriteLine($"Speed : {Speed}");
            Console.WriteLine($"Fuel Level : {FuelLevel}");
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Error: Enter the model name correctly");
                model = value;
            }
            
        } 

        public int Speed
        {
            get { return speed;}
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Error : The Speed must be positive ");
                speed = value;
            }
        }
        
        public int FuelLevel
        {
            get { return fuelLevel;}
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Error: It must have gasoline in it to work");
                fuelLevel = value;
            }
    }

        public void Accelerate(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Error : Accelerate must be greater than zero");
            
            int FuelNeed = 5;
            if (fuelLevel < FuelNeed)
                throw new ArgumentOutOfRangeException("Error : Not enough fuel for Acceleration");

            speed = speed + value;
            fuelLevel = fuelLevel - FuelNeed;
        }
        public void Decelerate(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Error : Decelerate must be greater than zero");
            int FualNeed = 2;
            if (fuelLevel < FualNeed)
                throw new ArgumentOutOfRangeException("Error : Not enough fuel for Acceleration");

            speed = speed - value;
            fuelLevel = fuelLevel - FualNeed;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                try 
                {
                    var vCar1 = new Car();
                    vCar1.Model = "BMW";
                    vCar1.Speed = 200;
                    vCar1.FuelLevel = 100;

                    vCar1.PrintInfoModel();

                    vCar1.Accelerate(50);
                    vCar1.PrintInfoModel();

                    vCar1.Decelerate(30);
                    vCar1.PrintInfoModel();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                }
            }
        }
    }
}