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
            this.flying = true;
        }

        public String getName() => (name);

        public Boolean isFlying() => (flying);

    }
}
