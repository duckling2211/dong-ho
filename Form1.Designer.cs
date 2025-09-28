namespace Clock
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
            this.components = new System.ComponentModel.Container();
            this.UniversalTick = new System.Windows.Forms.Timer(this.components);
            this.timezonePick = new System.Windows.Forms.TrackBar();
            this.Timezone = new System.Windows.Forms.Label();
            this.locationTZ = new System.Windows.Forms.Label();
            this.MeasureTimer = new System.Windows.Forms.Timer(this.components);
            this.StopWatchCircle = new CircularProgressBar.CircularProgressBar();
            this.SWPlay = new System.Windows.Forms.Button();
            this.SWPause = new System.Windows.Forms.Button();
            this.SWReset = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TimerPlay = new System.Windows.Forms.Button();
            this.TimerPause = new System.Windows.Forms.Button();
            this.TimerReset = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TimerCircle = new CircularProgressBar.CircularProgressBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timezonePick)).BeginInit();
            this.SuspendLayout();
            // 
            // UniversalTick
            // 
            this.UniversalTick.Enabled = true;
            this.UniversalTick.Interval = 1000;
            this.UniversalTick.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // timezonePick
            // 
            this.timezonePick.LargeChange = 1;
            this.timezonePick.Location = new System.Drawing.Point(131, 10);
            this.timezonePick.Margin = new System.Windows.Forms.Padding(2);
            this.timezonePick.Maximum = 12;
            this.timezonePick.Minimum = -12;
            this.timezonePick.Name = "timezonePick";
            this.timezonePick.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.timezonePick.Size = new System.Drawing.Size(56, 448);
            this.timezonePick.TabIndex = 0;
            this.timezonePick.Value = 7;
            this.timezonePick.ValueChanged += new System.EventHandler(this.timezonePick_ValueChanged);
            // 
            // Timezone
            // 
            this.Timezone.AutoSize = true;
            this.Timezone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timezone.Location = new System.Drawing.Point(31, 184);
            this.Timezone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Timezone.Name = "Timezone";
            this.Timezone.Size = new System.Drawing.Size(88, 25);
            this.Timezone.TabIndex = 1;
            this.Timezone.Text = "UTC +7";
            // 
            // locationTZ
            // 
            this.locationTZ.AutoSize = true;
            this.locationTZ.Location = new System.Drawing.Point(1, 208);
            this.locationTZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationTZ.Name = "locationTZ";
            this.locationTZ.Size = new System.Drawing.Size(62, 16);
            this.locationTZ.TabIndex = 2;
            this.locationTZ.Text = "Việt Nam";
            this.locationTZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MeasureTimer
            // 
            this.MeasureTimer.Enabled = true;
            this.MeasureTimer.Interval = 25;
            this.MeasureTimer.Tick += new System.EventHandler(this.MTimer);
            // 
            // StopWatchCircle
            // 
            this.StopWatchCircle.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.ExponentialEaseOut;
            this.StopWatchCircle.AnimationSpeed = 1000;
            this.StopWatchCircle.BackColor = System.Drawing.Color.Transparent;
            this.StopWatchCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopWatchCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StopWatchCircle.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StopWatchCircle.InnerMargin = 2;
            this.StopWatchCircle.InnerWidth = -1;
            this.StopWatchCircle.Location = new System.Drawing.Point(794, 11);
            this.StopWatchCircle.Margin = new System.Windows.Forms.Padding(2);
            this.StopWatchCircle.MarqueeAnimationSpeed = 2000;
            this.StopWatchCircle.Maximum = 60000;
            this.StopWatchCircle.Name = "StopWatchCircle";
            this.StopWatchCircle.OuterColor = System.Drawing.Color.Gray;
            this.StopWatchCircle.OuterMargin = -20;
            this.StopWatchCircle.OuterWidth = 20;
            this.StopWatchCircle.ProgressColor = System.Drawing.Color.Cyan;
            this.StopWatchCircle.ProgressWidth = 20;
            this.StopWatchCircle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.StopWatchCircle.Size = new System.Drawing.Size(146, 146);
            this.StopWatchCircle.StartAngle = 270;
            this.StopWatchCircle.Step = 1;
            this.StopWatchCircle.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.StopWatchCircle.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.StopWatchCircle.SubscriptText = ".23";
            this.StopWatchCircle.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.StopWatchCircle.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.StopWatchCircle.SuperscriptText = "°C";
            this.StopWatchCircle.TabIndex = 3;
            this.StopWatchCircle.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.StopWatchCircle.Value = 60000;
            this.StopWatchCircle.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // SWPlay
            // 
            this.SWPlay.BackColor = System.Drawing.Color.Lime;
            this.SWPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWPlay.Location = new System.Drawing.Point(795, 173);
            this.SWPlay.Margin = new System.Windows.Forms.Padding(2);
            this.SWPlay.Name = "SWPlay";
            this.SWPlay.Size = new System.Drawing.Size(42, 42);
            this.SWPlay.TabIndex = 5;
            this.SWPlay.Text = "⏵";
            this.SWPlay.UseVisualStyleBackColor = false;
            this.SWPlay.Click += new System.EventHandler(this.SWPlay_Click);
            // 
            // SWPause
            // 
            this.SWPause.BackColor = System.Drawing.Color.Gold;
            this.SWPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWPause.Location = new System.Drawing.Point(841, 173);
            this.SWPause.Margin = new System.Windows.Forms.Padding(2);
            this.SWPause.Name = "SWPause";
            this.SWPause.Size = new System.Drawing.Size(42, 42);
            this.SWPause.TabIndex = 6;
            this.SWPause.Text = "||";
            this.SWPause.UseVisualStyleBackColor = false;
            this.SWPause.Click += new System.EventHandler(this.SWPause_Click);
            // 
            // SWReset
            // 
            this.SWReset.BackColor = System.Drawing.Color.LightCoral;
            this.SWReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWReset.Location = new System.Drawing.Point(887, 173);
            this.SWReset.Margin = new System.Windows.Forms.Padding(2);
            this.SWReset.Name = "SWReset";
            this.SWReset.Size = new System.Drawing.Size(42, 42);
            this.SWReset.TabIndex = 7;
            this.SWReset.Text = "🔄";
            this.SWReset.UseVisualStyleBackColor = false;
            this.SWReset.Click += new System.EventHandler(this.SWReset_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(825, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 30);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "00:00:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TimerPlay
            // 
            this.TimerPlay.BackColor = System.Drawing.Color.Lime;
            this.TimerPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerPlay.Location = new System.Drawing.Point(795, 393);
            this.TimerPlay.Margin = new System.Windows.Forms.Padding(2);
            this.TimerPlay.Name = "TimerPlay";
            this.TimerPlay.Size = new System.Drawing.Size(42, 42);
            this.TimerPlay.TabIndex = 9;
            this.TimerPlay.Text = "⏵";
            this.TimerPlay.UseVisualStyleBackColor = false;
            this.TimerPlay.Click += new System.EventHandler(this.TMPlay);
            // 
            // TimerPause
            // 
            this.TimerPause.BackColor = System.Drawing.Color.Gold;
            this.TimerPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerPause.Location = new System.Drawing.Point(841, 393);
            this.TimerPause.Margin = new System.Windows.Forms.Padding(2);
            this.TimerPause.Name = "TimerPause";
            this.TimerPause.Size = new System.Drawing.Size(42, 42);
            this.TimerPause.TabIndex = 10;
            this.TimerPause.Text = "||";
            this.TimerPause.UseVisualStyleBackColor = false;
            this.TimerPause.Click += new System.EventHandler(this.TMPause);
            // 
            // TimerReset
            // 
            this.TimerReset.BackColor = System.Drawing.Color.LightCoral;
            this.TimerReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerReset.Location = new System.Drawing.Point(887, 393);
            this.TimerReset.Margin = new System.Windows.Forms.Padding(2);
            this.TimerReset.Name = "TimerReset";
            this.TimerReset.Size = new System.Drawing.Size(42, 42);
            this.TimerReset.TabIndex = 11;
            this.TimerReset.Text = "🔄";
            this.TimerReset.UseVisualStyleBackColor = false;
            this.TimerReset.Click += new System.EventHandler(this.TMReset);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(825, 289);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(84, 30);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "00:00:00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimerCircle
            // 
            this.TimerCircle.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;
            this.TimerCircle.AnimationSpeed = 500;
            this.TimerCircle.BackColor = System.Drawing.Color.Transparent;
            this.TimerCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TimerCircle.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TimerCircle.InnerMargin = 2;
            this.TimerCircle.InnerWidth = -1;
            this.TimerCircle.Location = new System.Drawing.Point(794, 231);
            this.TimerCircle.Margin = new System.Windows.Forms.Padding(2);
            this.TimerCircle.MarqueeAnimationSpeed = 2000;
            this.TimerCircle.Maximum = 60000;
            this.TimerCircle.Name = "TimerCircle";
            this.TimerCircle.OuterColor = System.Drawing.Color.Gray;
            this.TimerCircle.OuterMargin = -20;
            this.TimerCircle.OuterWidth = 20;
            this.TimerCircle.ProgressColor = System.Drawing.Color.Magenta;
            this.TimerCircle.ProgressWidth = 20;
            this.TimerCircle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.TimerCircle.Size = new System.Drawing.Size(146, 146);
            this.TimerCircle.StartAngle = 270;
            this.TimerCircle.Step = 1;
            this.TimerCircle.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TimerCircle.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.TimerCircle.SubscriptText = ".23";
            this.TimerCircle.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TimerCircle.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.TimerCircle.SuperscriptText = "°C";
            this.TimerCircle.TabIndex = 12;
            this.TimerCircle.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.TimerCircle.Value = 60000;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(879, 323);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(30, 22);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "000";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.HelpPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(952, 468);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TimerCircle);
            this.Controls.Add(this.TimerReset);
            this.Controls.Add(this.TimerPause);
            this.Controls.Add(this.TimerPlay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SWReset);
            this.Controls.Add(this.SWPause);
            this.Controls.Add(this.SWPlay);
            this.Controls.Add(this.StopWatchCircle);
            this.Controls.Add(this.locationTZ);
            this.Controls.Add(this.Timezone);
            this.Controls.Add(this.timezonePick);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.timezonePick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer UniversalTick;
        private System.Windows.Forms.TrackBar timezonePick;
        private System.Windows.Forms.Label Timezone;
        private System.Windows.Forms.Label locationTZ;
        private System.Windows.Forms.Timer MeasureTimer;
        private CircularProgressBar.CircularProgressBar StopWatchCircle;
        private System.Windows.Forms.Button SWPlay;
        private System.Windows.Forms.Button SWPause;
        private System.Windows.Forms.Button SWReset;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TimerPlay;
        private System.Windows.Forms.Button TimerPause;
        private System.Windows.Forms.Button TimerReset;
        private System.Windows.Forms.TextBox textBox2;
        private CircularProgressBar.CircularProgressBar TimerCircle;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
    }
}

