namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car()
            : this("VW", "Golf", 2025, 200, 10, new Engine(150, 2.0), new Tire[4] { new Tire(2022, 2.5), new Tire(2022, 2.5), new Tire(2022, 2.5), new Tire(2022, 2.5) })
        {
            // Parameterless constructor using default values
        }

        public Car(string make, string model, int year)
            : this(make, model, year, 200, 10, new Engine(150, 2.0), new Tire[4] { new Tire(2022, 2.5), new Tire(2022, 2.5), new Tire(2022, 2.5), new Tire(2022, 2.5) })
        {
            // Constructor with make, model, and year parameters, calling the base constructor
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year, fuelQuantity, fuelConsumption, new Engine(150, 2.0), new Tire[4] { new Tire(2022, 2.5), new Tire(2022, 2.5), new Tire(2022, 2.5), new Tire(2022, 2.5) })
        {
            // Constructor with make, model, year, fuelQuantity, and fuelConsumption parameters, reusing the second constructor
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
            this.engine = engine;
            this.tires = tires;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public void Drive(double distance)
        {
            double neededFuel = distance * fuelConsumption;

            if (fuelQuantity >= neededFuel)
            {
                fuelQuantity -= neededFuel;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}";
        }
    }
}
