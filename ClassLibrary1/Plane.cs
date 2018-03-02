using System;
using System.Collections.Generic;
using System.Text;

namespace AirportChallengeLib
{
    public class Plane
    {

        String name;
        Boolean flying;

        public Plane(String name)
        {
            this.name = name;
            flying = true;
        }

        public void Land()
        {
            flying = false;
        }

        public String GetName() => (name);

        public Boolean IsFlying() => (flying);

    }
}
