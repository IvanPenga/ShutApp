namespace ShutApp
{
    partial class Main
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
            this.startCountDown = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblListening = new System.Windows.Forms.Label();
            this.rlSleep = new ShutApp.ccRadioLabel();
            this.rlRestart = new ShutApp.ccRadioLabel();
            this.rlShutdown = new ShutApp.ccRadioLabel();
            this.ucSeconds = new ShutApp.ucTime();
            this.ucMinutes = new ShutApp.ucTime();
            this.ucHours = new ShutApp.ucTime();
            this.SuspendLayout();
            // 
            // startCountDown
            // 
            this.startCountDown.Interval = 1000;
            this.startCountDown.Tick += new System.EventHandler(this.startCountDown_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(683, 254);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 52);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 12);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::ShutApp.Properties.Resources.wilmington_divider_white;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(704, 241);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 17);
            this.panel2.TabIndex = 15;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimize.BackgroundImage = global::ShutApp.Properties.Resources.ic_remove_white_2x;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(793, 20);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 21);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.BackgroundImage = global::ShutApp.Properties.Resources.ic_close_white_2x;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(821, 20);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 21);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // lblListening
            // 
            this.lblListening.AutoSize = true;
            this.lblListening.BackColor = System.Drawing.Color.Transparent;
            this.lblListening.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblListening.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblListening.Location = new System.Drawing.Point(695, 309);
            this.lblListening.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListening.Name = "lblListening";
            this.lblListening.Size = new System.Drawing.Size(128, 29);
            this.lblListening.TabIndex = 16;
            this.lblListening.Text = "Listening...";
            this.lblListening.Visible = false;
            // 
            // rlSleep
            // 
            this.rlSleep.AutoSize = true;
            this.rlSleep.Checked = false;
            this.rlSleep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rlSleep.Enable = true;
            this.rlSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rlSleep.ForeColor = System.Drawing.Color.White;
            this.rlSleep.Location = new System.Drawing.Point(711, 127);
            this.rlSleep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rlSleep.Name = "rlSleep";
            this.rlSleep.Size = new System.Drawing.Size(83, 31);
            this.rlSleep.TabIndex = 13;
            this.rlSleep.Text = "Sleep";
            // 
            // rlRestart
            // 
            this.rlRestart.AutoSize = true;
            this.rlRestart.Checked = false;
            this.rlRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rlRestart.Enable = true;
            this.rlRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rlRestart.ForeColor = System.Drawing.Color.White;
            this.rlRestart.Location = new System.Drawing.Point(701, 180);
            this.rlRestart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rlRestart.Name = "rlRestart";
            this.rlRestart.Size = new System.Drawing.Size(103, 31);
            this.rlRestart.TabIndex = 12;
            this.rlRestart.Text = "Restart";
            // 
            // rlShutdown
            // 
            this.rlShutdown.AutoSize = true;
            this.rlShutdown.Checked = false;
            this.rlShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rlShutdown.Enable = true;
            this.rlShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rlShutdown.ForeColor = System.Drawing.Color.White;
            this.rlShutdown.Location = new System.Drawing.Point(685, 69);
            this.rlShutdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rlShutdown.Name = "rlShutdown";
            this.rlShutdown.Size = new System.Drawing.Size(135, 31);
            this.rlShutdown.TabIndex = 10;
            this.rlShutdown.Text = "Shutdown";
            // 
            // ucSeconds
            // 
            this.ucSeconds.IsHour = false;
            this.ucSeconds.Location = new System.Drawing.Point(448, 17);
            this.ucSeconds.Margin = new System.Windows.Forms.Padding(5);
            this.ucSeconds.Name = "ucSeconds";
            this.ucSeconds.Size = new System.Drawing.Size(229, 340);
            this.ucSeconds.TabIndex = 2;
            this.ucSeconds.Time = 0;
            this.ucSeconds.TimeStampHMS = "Seconds";
            // 
            // ucMinutes
            // 
            this.ucMinutes.IsHour = false;
            this.ucMinutes.Location = new System.Drawing.Point(229, 17);
            this.ucMinutes.Margin = new System.Windows.Forms.Padding(5);
            this.ucMinutes.Name = "ucMinutes";
            this.ucMinutes.Size = new System.Drawing.Size(233, 340);
            this.ucMinutes.TabIndex = 1;
            this.ucMinutes.Time = 0;
            this.ucMinutes.TimeStampHMS = "Minutes";
            // 
            // ucHours
            // 
            this.ucHours.IsHour = true;
            this.ucHours.Location = new System.Drawing.Point(7, 17);
            this.ucHours.Margin = new System.Windows.Forms.Padding(5);
            this.ucHours.Name = "ucHours";
            this.ucHours.Size = new System.Drawing.Size(245, 340);
            this.ucHours.TabIndex = 0;
            this.ucHours.Time = 0;
            this.ucHours.TimeStampHMS = "Hours";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(855, 367);
            this.Controls.Add(this.lblListening);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rlSleep);
            this.Controls.Add(this.rlRestart);
            this.Controls.Add(this.rlShutdown);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ucSeconds);
            this.Controls.Add(this.ucMinutes);
            this.Controls.Add(this.ucHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShutApp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer startCountDown;
        private ucTime ucHours;
        private ucTime ucMinutes;
        private ucTime ucSeconds;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private ccRadioLabel rlShutdown;
        private ccRadioLabel rlRestart;
        private ccRadioLabel rlSleep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblListening;
    }
}

