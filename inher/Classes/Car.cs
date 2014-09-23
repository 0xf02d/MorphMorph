using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inher.Classes
{
    class Car: Vehicle
    {
        public string Manufacturer { get; private set; }
        public Car(string name, float speed, string manufacturer)
            : base(name, speed)
        {
            this.Manufacturer = manufacturer;
        }

        public override string Start()
        {
            return "The " +Manufacturer +" "+ Name+" drives away, after an hour it is " + base.Speed + " kilometers away.";
        }
    }
}
