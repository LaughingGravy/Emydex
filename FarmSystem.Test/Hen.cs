using System;

namespace FarmSystem.Test
{
    public class Hen : FarmAnimal
    {
        public Hen(string id, int noOfLegs)
        {
            this.Id = id;
            this.NoOfLegs = noOfLegs;
        }

        public override void Talk()
        {
            Console.WriteLine("Hen says CLUCKAAAAAWWWWK!");
        }
    }
}