using System;

namespace FarmSystem.Test
{
    /// <summary>
    /// Base abstract class of all farm animals
    /// </summary>
    public abstract class FarmAnimal : ITalk, IRun
    {
        protected string Id;
        protected int NoOfLegs;

        public abstract void Talk();

        public virtual void Run()
        {
            Console.WriteLine("{0} is running", (this).GetType().Name);
        }
    }
}
