using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inher.Classes
{
    class Vehicle
    {
        private double p;

        public string Name { get; private set; }
        public float Speed { get; private set; }
        public Vehicle(string name, float speed)
        {
            this.Name = name;
            this.Speed = speed;
        }
        public Vehicle()
        {

        }
        public virtual string Start()
        {
            return "an unknown vehicle is Starting";
        }
    }
}
