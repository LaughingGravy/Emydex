using System;

namespace FarmSystem.Test
{
    public class Cow : FarmAnimal, IWalk, IMilkableAnimal
    {
        public Cow(string id, int noOfLegs)
        {
            this.Id = id;
            this.NoOfLegs = noOfLegs;
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }

        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }
    }
}