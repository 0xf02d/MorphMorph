using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inher.Classes
{
    class Bicycle:Vehicle
    {
        public int gears { get; private set; }
        public string color { get; private set; }
        public Bicycle(string name, float speed, int gears, string color)
            : base(name, speed)
        {
            this.gears = gears;
            this.color = color;
        }
        public override string Start()
        {
            return "you do not start a bike, anyhow the "+ color+ " "+ Name+ " gets "+ Speed+ "k away whithin an hour, thanks to its "+ gears+ " Gears"  ;
        }

    }
}
