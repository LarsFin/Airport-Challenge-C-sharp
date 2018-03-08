// <copyright file="Airport.cs" company="None">
//     Free to use.
// </copyright>
namespace AirportChallengeLib
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Stores planes. Can also takeoff and receive planes. 
    /// </summary>
    /// <param name="name">The name of the airport instance created</param>
    public class Airport
    {
        /// <summary>
        /// The capacity of the hangar (the number of planes the airport can hold).
        /// </summary>
        private const int Capacity = 10;

        /// <summary>
        /// The name of the Airport.
        /// </summary>
        private string name;

        /// <summary>
        /// The hangar of the airport which stores the planes.
        /// </summary>
        private List<Plane> hangar;

        /// <summary>
        /// Initializes a new instance of the <see cref="Airport"/> class.
        /// </summary> 
        /// <param name="name">The name to be given to the Airport instance.</param>
        public Airport(string name)
        {
            this.name = name;
            this.hangar = new List<Plane>();
        }

        /// <summary>
        /// Allows Airport to take planes and store them in it's hangar.
        /// </summary> 
        /// <param name="plane">The plane to land at the airport</param>
        public void Take(Plane plane) 
        {
            plane.Land();
            this.hangar.Add(plane);
        }

        /// <summary>
        /// Allows Airport to take off planes and take them away from the hangar as well as calling fly on them.
        /// Unlike the Take() method the TakeOff() method takes the name of the plane desired to take off.
        /// </summary> 
        /// <param name="planeName">The name of the plane to take off from the airport</param>
        public void TakeOff(string planeName)
        {
            bool planeFound = false;
            for (var i = 0; i < this.hangar.Count; i++)
            {
                Plane plane = this.hangar[i];
                if (plane.GetName().Equals(planeName))
                {
                    planeFound = true;
                    plane.Fly();
                    this.hangar.Remove(plane);
                }
            }

            if (!planeFound)
            {
                throw new System.ArgumentException("Plane was not found!");
            }
        }

        /// <summary>
        /// Retrieves the name of the Airport called upon.
        /// </summary> 
        /// <returns>Airport name</returns>
        public string GetName() => this.name;

        /// <summary>
        /// Retrieves the list of planes currently within the hangar.
        /// </summary> 
        /// <returns>List of planes</returns>
        public List<Plane> GetHangar() => this.hangar;

        /// <summary>
        /// Retrieves the capacity of the hangar of the airport.
        /// </summary> 
        /// <returns>The capacity of the airport hangar</returns>
        public int GetCapacity() => Capacity;
    }
}
