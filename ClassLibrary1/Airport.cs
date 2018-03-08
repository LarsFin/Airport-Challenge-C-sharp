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

        public void Take(Plane plane) 
        {
            plane.Land();
            hangar.Add(plane);
        }

        public void TakeOff(String planeName)
        {
            Boolean planeFound = false;
            for (var i = 0; i < hangar.Count; i++)
            {
                Plane plane = hangar[i];
                if (plane.GetName().Equals(planeName))
                {
                    planeFound = true;
                    plane.Fly();
                    hangar.Remove(plane);
                }
            }
            if (!planeFound)
            {
                throw new System.ArgumentException("Plane was not found!");
            }
        }
        
        public String GetName() => (name);

        public List<Plane> GetHangar() => (hangar);

    }
}
