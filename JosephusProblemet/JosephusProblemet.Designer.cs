namespace JosephusProblemet
{
    partial class JosephusProblemet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPrisonersN = new TextBox();
            textBoxIntervalK = new TextBox();
            buttonKillPrisoners = new Button();
            PrisonersLabel = new Label();
            IntervalKLabel = new Label();
            SuspendLayout();
            // 
            // textBoxPrisonersN
            // 
            textBoxPrisonersN.Location = new Point(12, 44);
            textBoxPrisonersN.Name = "textBoxPrisonersN";
            textBoxPrisonersN.Size = new Size(206, 27);
            textBoxPrisonersN.TabIndex = 0;
            textBoxPrisonersN.TextChanged += TextBoxPrisonersN_TextChanged;
            // 
            // textBoxIntervalK
            // 
            textBoxIntervalK.Location = new Point(12, 134);
            textBoxIntervalK.Name = "textBoxIntervalK";
            textBoxIntervalK.Size = new Size(206, 27);
            textBoxIntervalK.TabIndex = 1;
            textBoxIntervalK.TextChanged += TextboxIntervalK_TextChanged;
            // 
            // buttonKillPrisoners
            // 
            buttonKillPrisoners.Location = new Point(12, 205);
            buttonKillPrisoners.Name = "buttonKillPrisoners";
            buttonKillPrisoners.Size = new Size(206, 69);
            buttonKillPrisoners.TabIndex = 2;
            buttonKillPrisoners.Text = "Kill Prisoners";
            buttonKillPrisoners.UseVisualStyleBackColor = true;
            buttonKillPrisoners.Click += ButtonKillPrisoners_Click;
            buttonKillPrisoners.Enabled = false;
            // 
            // PrisonersLabel
            // 
            PrisonersLabel.AutoSize = true;
            PrisonersLabel.Location = new Point(12, 21);
            PrisonersLabel.Name = "PrisonersLabel";
            PrisonersLabel.Size = new Size(144, 20);
            PrisonersLabel.TabIndex = 3;
            PrisonersLabel.Text = "Number of Prisoners";
            // 
            // IntervalKLabel
            // 
            IntervalKLabel.AutoSize = true;
            IntervalKLabel.Location = new Point(12, 111);
            IntervalKLabel.Name = "IntervalKLabel";
            IntervalKLabel.Size = new Size(101, 20);
            IntervalKLabel.TabIndex = 4;
            IntervalKLabel.Text = "Interval to Kill";
            // 
            // JosephusProblemet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 286);
            Controls.Add(IntervalKLabel);
            Controls.Add(PrisonersLabel);
            Controls.Add(buttonKillPrisoners);
            Controls.Add(textBoxIntervalK);
            Controls.Add(textBoxPrisonersN);
            Name = "JosephusProblemet";
            Text = "JosephusProblemet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPrisonersN;
        private TextBox textBoxIntervalK;
        private Button buttonKillPrisoners;
        private Label PrisonersLabel;
        private Label IntervalKLabel;
    }
}