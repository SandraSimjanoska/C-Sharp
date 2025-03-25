namespace Class05.Homework
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, int speed, Driver driver = null)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public double CalculateSpeed()
        {
            if (Driver == null) return 0;
            return Driver.Skill * Speed;
        }
    }
}
