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
            hangar = new List<Plane>();
        }

        public String GetName() => (name);

        public List<Plane> GetHangar() => (hangar);

    }
}
