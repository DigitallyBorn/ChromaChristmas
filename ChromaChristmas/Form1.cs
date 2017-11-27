using System.Windows.Forms;
using Corale.Colore.Razer.Keyboard;
using Corale.Colore.Core;
using System;

namespace ChromaChristmas
{
    public partial class Form1 : Form
    {
        public readonly Color[] COLORS = new[] { Color.Red, Color.Blue, Color.Green, Color.White, Color.Yellow };
        public readonly Timer mainTimer;
        public readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            this.FormClosing += Form1_FormClosing;
            this.Activated += Form1_Activated;

            mainTimer = new Timer();
            mainTimer.Tick += Timer_Tick;
            mainTimer.Interval = 250;
            mainTimer.Start();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Chroma.Instance.Keyboard.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainTimer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            mainTimer.Interval = random.Next(1000) + 100;
            SetRandomKey();
        }

        private void SetRandomKey()
        {
            var column = random.Next(Constants.MaxColumns);
            var row = random.Next(Constants.MaxRows);

            var randomColor = COLORS[random.Next(COLORS.Length - 1)];
            
            Chroma.Instance.Keyboard[row, column] = randomColor;

            var clearKeyTimer = new Timer();
            clearKeyTimer.Tick += ClearKeyTimer_Tick;
            clearKeyTimer.Tag = new Tuple<int, int>(row, column);
            clearKeyTimer.Interval = random.Next(2000) + 1000;
            clearKeyTimer.Start();
        }

        private void ClearKeyTimer_Tick(object sender, EventArgs e)
        {
            var timer = (Timer)sender;
            timer.Stop();

            var coords = (Tuple<int, int>)timer.Tag;

            Chroma.Instance.Keyboard[coords.Item1, coords.Item2] = Color.Black;
        }
    }
}
