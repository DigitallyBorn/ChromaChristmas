using System.Windows.Forms;
using System;

namespace ChromaChristmas
{
    public partial class Form1 : Form
    {
        public Blinking controller;
        public bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
            controller = new Blinking();
            ColorSetSelector.SelectedIndex = 0;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            isRunning = true;
            controller.Start();
            EnableFormControls();
        }

        private void EnableFormControls()
        {
            StartButton.Enabled = !isRunning;
            StopButton.Enabled = isRunning;
            LightCountSelector.Enabled = !isRunning;
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            isRunning = false;
            controller.Stop();
            EnableFormControls();
        }

        private void LightCountSelector_ValueChanged(object sender, EventArgs e)
        {
            controller.ThreadCount = Convert.ToInt32(LightCountSelector.Value);
        }

        private void ColorSetSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ColorSetSelector.SelectedItem)
            {
                case "Default":
                    controller.ColorSet = Blinking.ColorSets.Default;
                    break;
                case "Only White":
                    controller.ColorSet = Blinking.ColorSets.OnlyWhite;
                    break;
                case "'Merica!":
                    controller.ColorSet = Blinking.ColorSets.Merica;
                    break;
                default:
                    break;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            EnableFormControls();
        }
    }
}
