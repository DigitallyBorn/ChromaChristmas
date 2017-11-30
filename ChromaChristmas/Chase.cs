using Corale.Colore.Core;
using Corale.Colore.Razer.Keyboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChromaChristmas
{
    class Chase : LightController
    {
        private Timer mainTimer;
        private Tuple<int, int> headPosition = new Tuple<int, int>(0, -1);
        private Tuple<int, int> tailPosition = new Tuple<int, int>(0, -1);
        private bool tailStarted = false;

        public int Length => 3;

        public Chase()
        {
            mainTimer = new Timer(Update);
        }

        public override void Start()
        {
            mainTimer.Change(0, 20);
        }

        public override void Stop()
        {
            mainTimer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        private void Update(object state)
        {
            UpdateHead();
            UpdateTail();
        }

        private void UpdateHead()
        {
            int newHeadRow = headPosition.Item1;
            int newHeadColumn = headPosition.Item2 + 1;

            if (newHeadColumn >= Constants.MaxColumns)
            {
                newHeadColumn = 0;
                newHeadRow += 1;

                if (newHeadRow >= Constants.MaxRows)
                    newHeadRow = 0;
            }

            if (!tailStarted && newHeadColumn > Length)
                tailStarted = true;

            headPosition = new Tuple<int, int>(newHeadRow, newHeadColumn);
            Chroma.Instance.Keyboard[headPosition.Item1, headPosition.Item2] = Color.White;
        }

        private void UpdateTail()
        {
            if (!tailStarted)
                return;

            int newTailRow = tailPosition.Item1;
            int newTailColumn = tailPosition.Item2 + 1;

            if (newTailColumn >= Constants.MaxColumns)
            {
                newTailColumn = 0;
                newTailRow += 1;

                if (newTailRow >= Constants.MaxRows)
                    newTailRow = 0;
            }

            tailPosition = new Tuple<int, int>(newTailRow, newTailColumn);
            Chroma.Instance.Keyboard[tailPosition.Item1, tailPosition.Item2] = Color.Black;
        }
    }
}
