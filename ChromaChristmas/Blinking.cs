using System.Windows.Forms;
using Corale.Colore.Core;
using System;
using System.Collections.Generic;

namespace ChromaChristmas
{
    public class Blinking : LightController
    {
        public int ThreadCount { get; set; } = 5;

        public static class ColorSets
        {
            public static readonly Color[] Default = new[]
            {
                Color.Red,
                Color.Blue,
                Color.Green,
                Color.White,
                Color.Purple
            };

            public static readonly Color[] OnlyWhite = new[] { Color.White };
            public static readonly Color[] Merica = new[] { Color.Red, Color.White, Color.Blue };
        }


        public Color[] ColorSet = ColorSets.Default;

        public readonly List<Timer> keyTimers;
        public bool running = false;

        public Blinking()
        {
            keyTimers = new List<Timer>(ThreadCount);
        }

        public override void Start()
        {
            running = true;
            Chroma.Instance.Initialize();
            Chroma.Instance.Keyboard.Clear();

            for (int i = 0; i < (ThreadCount - 1); i++)
            {
                var timer = new Timer();

                keyTimers.Add(timer);
                timer.Interval = random.Next(999) + 1;
                timer.Tag = DetermineRandomLocation();
                timer.Tick += KeyTimer_Tick;
                timer.Start();
            }
        }

        public override void Stop()
        {
            running = false;
            Chroma.Instance.SetAll(Color.Black);
            Chroma.Instance.Uninitialize();

            foreach (var timer in keyTimers)
            {
                timer.Stop();
            }

            keyTimers.Clear();
        }

        private void KeyTimer_Tick(object sender, EventArgs e)
        {
            var timer = (Timer)sender;
            timer.Stop();

            if (!running)
                return;

            var coords = (Tuple<int, int>)timer.Tag;
            Chroma.Instance.Keyboard[coords.Item1, coords.Item2] = Color.Black;

            timer.Interval = random.Next(3750) + 250;
            var newLocation = DetermineRandomLocation();
            timer.Tag = newLocation;

            var randomColor = ColorSet[random.Next(ColorSet.Length)];
            Chroma.Instance.Keyboard[newLocation.Item1, newLocation.Item2] = randomColor;

            timer.Start();
        }
    }
}
