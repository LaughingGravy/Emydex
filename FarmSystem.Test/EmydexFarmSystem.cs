using System;
using System.Collections.Generic;

namespace FarmSystem.Test
{
    public class EmydexFarmSystem
    {
        public event EventHandler FarmEmpty;
        private Queue<FarmAnimal> _farm;

        public EmydexFarmSystem()
        {
            this._farm = new Queue<FarmAnimal>();
        }

        //TEST 1
        public void Enter(FarmAnimal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            this._farm.Enqueue(animal);
            Console.WriteLine("{0} has entered the farm", animal.GetType().Name);
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            foreach(FarmAnimal animal in this._farm.ToArray())
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (FarmAnimal animal in this._farm.ToArray())
            {
                if (animal is IMilkableAnimal milkableAnimal)
                {
                    milkableAnimal.ProduceMilk();
                }
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            while (this._farm.Count > 0)
            {
                FarmAnimal releasedAnimal = this._farm.Dequeue();
                Console.WriteLine("{0} has left the farm", releasedAnimal.GetType().Name);
            }

            this.OnFarmEmpty(EventArgs.Empty);
        }

        protected virtual void OnFarmEmpty(EventArgs e)
        {
            EventHandler handler = FarmEmpty;
            handler?.Invoke(this, e);
        }
    }
}