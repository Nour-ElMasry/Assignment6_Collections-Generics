using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        protected int _horsePower;
        protected string _carType;
        public Car(string brand, int cost, string carType, int horsePower) : base(brand, cost)
        {
            _carType = carType;
            _horsePower = horsePower;
        }

        public override string Info()
        {
            return $"Car brand: {Brand}, costs {Cost} , Type: {_carType} and Horse Power: { _horsePower }.";
        }

        public override string? ToString()
        {
            return Info();
        }
    }
}
