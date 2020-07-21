using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_COMP123
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        public GiantPlanet(string name, double diameter, double mass, string type)
            :base(name, diameter, mass)
        {
            if (type == "Gas" || type == "Ice")
            {
                this._type = type;
            }
            else
            {
                Console.WriteLine("type should be either Gas or Ice");
            }

        }

        public bool HasMoons()
        {
            if(MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
