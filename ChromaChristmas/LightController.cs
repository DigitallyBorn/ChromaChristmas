using Corale.Colore.Razer.Keyboard;
using System;

namespace ChromaChristmas
{
    public abstract class LightController
    {
        protected readonly Random random = new Random();

        public abstract void Start();
        public abstract void Stop();

        protected Tuple<int, int> DetermineRandomLocation()
        {
            var column = random.Next(Constants.MaxColumns);
            var row = random.Next(Constants.MaxRows);

            return new Tuple<int, int>(row, column);
        }
    }
}
