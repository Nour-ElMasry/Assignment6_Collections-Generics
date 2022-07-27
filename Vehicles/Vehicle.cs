namespace Vehicles
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public int Cost { get; set; }
        public Vehicle(string brand, int cost) {
            Brand = brand;
            Cost = cost;
        }

        public abstract string Info();
    }
}