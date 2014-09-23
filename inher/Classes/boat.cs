using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inher.Classes
{
    class Boat:Vehicle
    {
        public bool canSwim { get { return true; } }
        public bool isMotorized {get;private set;}
        public Boat(string name, float speed, bool isMotorized)
            : base(name,( speed / 2))
        {
            this.isMotorized = isMotorized;
        }
        public override string Start()
        {
            if (isMotorized)
                return "The boat" + base.Name + " tuckes of the shore, after an hour it is " + base.Speed + " nautic miles away.";
            else
                return "Grab a paddel!, the " + base.Name + "does not have a motor";
        }

    }
}
