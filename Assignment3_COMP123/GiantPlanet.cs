using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_COMP123
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        public GiantPlanet(string type)
            : base("ho",7,7)
        {
            this._type = type;

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
