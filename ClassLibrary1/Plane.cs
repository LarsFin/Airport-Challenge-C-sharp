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

        public virtual void Land()
        {
            flying = false;
        }

        public virtual void Fly()
        {
            flying = true;
        }

        public String GetName() => (name);

        public Boolean IsFlying() => (flying);

    }
}
