using System;

namespace FarmSystem.Test
{
    public class Horse : FarmAnimal
    {
        public Horse(string id, int noOfLegs)
        {
            this.Id = id;
            this.NoOfLegs = noOfLegs;
        }

        public override void Talk()
        {
            Console.WriteLine("Horse says Neigh!");
        }
    }
}