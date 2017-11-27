using System.Windows.Forms;
using Corale.Colore.Razer.Keyboard;
using Corale.Colore.Core;
using System;
using System.Collections.Generic;

namespace ChromaChristmas
{
    public partial class Form1 : Form
    {
        const int THREAD_COUNT = 15;

        public readonly Color[] COLORS = new[] { Color.Red, Color.Blue, Color.Green, Color.White, Color.Yellow };
        public readonly List<Timer> keyTimers = new List<Timer>(THREAD_COUNT);
        public readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            this.FormClosing += Form1_FormClosing;
            this.Activated += Form1_Activated;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Chroma.Instance.Keyboard.Clear();

            for (int i = 0; i < (THREAD_COUNT - 1); i++)
            {
                var timer = new Timer();

                keyTimers.Add(timer);
                timer.Interval = random.Next(1000);
                timer.Tag = DetermineRandomLocation();
                timer.Tick += KeyTimer_Tick;
                timer.Start();
            }
        }

        private void KeyTimer_Tick(object sender, EventArgs e)
        {
            var timer = (Timer)sender;
            timer.Stop();

            var coords = (Tuple<int, int>)timer.Tag;
            Chroma.Instance.Keyboard[coords.Item1, coords.Item2] = Color.Black;

            timer.Interval = random.Next(1750) + 250;
            var newLocation = DetermineRandomLocation();
            timer.Tag = newLocation;

            var randomColor = COLORS[random.Next(COLORS.Length)];
            Chroma.Instance.Keyboard[newLocation.Item1, newLocation.Item2] = randomColor;

            timer.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: cleanup timers
        }

        private Tuple<int, int> DetermineRandomLocation()
        {
            var column = random.Next(Constants.MaxColumns);
            var row = random.Next(Constants.MaxRows);

            return new Tuple<int, int>(row, column);
        }
    }
}
