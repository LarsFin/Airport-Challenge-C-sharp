using System;
using System.Collections.Generic;
using System.Text;

namespace AirportChallengeLib
{
    public class Airport
    {

        String name;
        List<Plane> hangar;

        public Airport(String name)
        {
            this.name = name;
            this.hangar = new List<Plane>();
        }

        public String getName() => (name);

        public List<Plane> getHangar() => (hangar);

    }
}
