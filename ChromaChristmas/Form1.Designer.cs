namespace ChromaChristmas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.LightCountSelector = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorSetSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LightCountSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StopButton.Location = new System.Drawing.Point(182, 60);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(72, 36);
            this.StopButton.TabIndex = 0;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartButton.Location = new System.Drawing.Point(104, 60);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(72, 36);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LightCountSelector
            // 
            this.LightCountSelector.Location = new System.Drawing.Point(105, 7);
            this.LightCountSelector.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.LightCountSelector.Name = "LightCountSelector";
            this.LightCountSelector.Size = new System.Drawing.Size(47, 20);
            this.LightCountSelector.TabIndex = 2;
            this.LightCountSelector.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.LightCountSelector.ValueChanged += new System.EventHandler(this.LightCountSelector_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Lights";
            // 
            // ColorSetSelector
            // 
            this.ColorSetSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorSetSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorSetSelector.FormattingEnabled = true;
            this.ColorSetSelector.Items.AddRange(new object[] {
            "Default",
            "Only White",
            "\'Merica!"});
            this.ColorSetSelector.Location = new System.Drawing.Point(105, 33);
            this.ColorSetSelector.Name = "ColorSetSelector";
            this.ColorSetSelector.Size = new System.Drawing.Size(149, 21);
            this.ColorSetSelector.TabIndex = 4;
            this.ColorSetSelector.SelectedIndexChanged += new System.EventHandler(this.ColorSetSelector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Color Set";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 108);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColorSetSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LightCountSelector);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "A Very Chroma Christmas";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.LightCountSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown LightCountSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ColorSetSelector;
        private System.Windows.Forms.Label label2;
    }
}

