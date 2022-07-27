using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Aircraft : Vehicle
    { 
        protected int _capacity;
        public Aircraft(string brand, int cost, int capacity) : base(brand, cost)
        {
            _capacity = capacity;
        }

        public override string Info()
        {
            return $"Aircraft brand:{ Brand }, cost: { Cost } and capacity: { _capacity } people.";
        }

        public override string? ToString()
        {
            return Info();
        }
    }
}

