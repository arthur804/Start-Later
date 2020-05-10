namespace StartLater
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
            if(disposing && (components != null))
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
            this.urlBox = new System.Windows.Forms.TextBox();
            this.hoursInput = new StartLater.BetterUpDown();
            this.minutesInput = new StartLater.BetterUpDown();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoursInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesInput)).BeginInit();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(13, 13);
            this.urlBox.Size = new System.Drawing.Size(100, 20);
            this.urlBox.TabIndex = 0;
            // 
            // hoursInput
            // 
            this.hoursInput.Location = new System.Drawing.Point(13, 40);
            this.hoursInput.Maximum = new decimal(24);
            this.hoursInput.Minimum = -1;
            this.hoursInput.Size = new System.Drawing.Size(48, 20);
            this.hoursInput.TabIndex = 1;
            this.hoursInput.ValueChanged += new System.EventHandler(this.HoursInput_ValueChanged);
            // 
            // minutesInput
            // 
            this.minutesInput.Increment = 10;
            this.minutesInput.Location = new System.Drawing.Point(67, 40);
            this.minutesInput.Maximum = 60;
            this.minutesInput.Minimum = -1;
            this.minutesInput.Size = new System.Drawing.Size(48, 20);
            this.minutesInput.TabIndex = 2;
            this.minutesInput.ValueChanged += new System.EventHandler(this.MinutesInput_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(119, 10);
            this.startButton.Size = new System.Drawing.Size(50, 82);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Set Timer";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new System.Drawing.Size(181, 104);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.minutesInput);
            this.Controls.Add(this.hoursInput);
            this.Controls.Add(this.urlBox);
            this.Text = "AutoLauncher";
            ((System.ComponentModel.ISupportInitialize)(this.hoursInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private BetterUpDown hoursInput;
        private BetterUpDown minutesInput;
        private System.Windows.Forms.Button startButton;
    }
}

