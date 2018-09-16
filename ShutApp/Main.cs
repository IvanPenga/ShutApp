using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.IO;

namespace ShutApp
{
    public partial class Main : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public Main()
        {
            InitializeComponent();
            Speech(); //enables speech recognition
            ucSeconds.greater = ucMinutes;
            ucMinutes.greater = ucHours;
            ucHours.greater = new ucTime { greater = new ucTime() };

            rlShutdown.Checked = true;
        }

        private void startCountDown_Tick(object sender, EventArgs e)
        {

            if (ucSeconds.Time == 0 && ucMinutes.Time == 0 && ucHours.Time == 0)
            {
                startCountDown.Stop();
                StartShutdown();
            }
            else
            {
                ucSeconds.Time--;
            }
        }

        private void StartShutdown()
        {
            if (rlShutdown.Checked)
            {
                var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);

            }
            if (rlRestart.Checked)
            {
                var psi = new ProcessStartInfo("shutdown", "/r /t 0");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
            if (rlSleep.Checked)
            {

            }
        }

        private void StartCountdown()
        {
            IsStart = false;
            btnStart.Text = "Stop";
            AllRadioLabelsEnabled(false);

            startCountDown.Start();
        }
        private void StopCountdown()
        {
            IsStart = true;
            btnStart.Text = "Start";
            AllRadioLabelsEnabled(true);

            startCountDown.Stop();
        }

        private bool IsStart = true;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (IsStart)
            {
                StartCountdown();
            }
            else
            {
                StopCountdown();
            }
        }

        private void AllRadioLabelsEnabled(bool state)
        {
            rlShutdown.Enable = state;
            rlRestart.Enable = state;
            rlSleep.Enable = state;
        }

        private void DisableAllButtons()
        {
            ucSeconds.DisableButtons();
            ucMinutes.DisableButtons();
            ucHours.DisableButtons();
        }
        private void EnableAllButtons()
        {
            ucSeconds.EnableButtons();
            ucMinutes.EnableButtons();
            ucHours.EnableButtons();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool cached = false;
        int yDistance = 0;
        int xDistance = 0;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            cached = true;
            yDistance = e.Y;
            xDistance = e.X;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            cached = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (cached)
            {
                this.Top = Cursor.Position.Y - yDistance;
                this.Left = Cursor.Position.X - xDistance;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.CornflowerBlue;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.White;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.FlatAppearance.BorderSize = 0;
        }

        Choices commands;
        private void Speech()
        {
            commands = new Choices();
            commands.Add("ok penga");
            commands.Add("start");
            commands.Add("stop");
            commands.Add("set shutdown in one hour");
            commands.Add("set shutdown in two hours");

            for (int i = 0; i < 60; i++)
            {
                commands.Add(i.ToString());
            }

            commands.Add("exit application");

            try
            {
                GrammarBuilder gBuilder = new GrammarBuilder();
                gBuilder.Append(commands);
                Grammar grammar = new Grammar(gBuilder);

                recEngine.LoadGrammarAsync(grammar);
                recEngine.SetInputToDefaultAudioDevice();

                //this starts speech rec input
                recEngine.RecognizeAsync(RecognizeMode.Multiple);
                recEngine.SpeechRecognized += RecEngine_SpeechRecognized;
            }
            catch (Exception)
            {
               // lblListening.Visible = true;
               // lblListening.Text = "No voice\ncontrol";
            }
        }
        bool okPenga = false;
        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "ok penga":
                    lblListening.Visible = true;
                    okPenga = true;
                    return;
            } 
            if (okPenga == true) ListenNextTask(e.Result.Text);
        }

        private void ListenNextTask(string sentence)
        {
            switch (sentence)
            {
                case "start":
                    StartCountdown();
                    break;
                case "stop":
                    StopCountdown();
                    break;
                case "set shutdown in one hour":
                    SetTime(1, 0, 0);
                    StartCountdown();
                    break;
                case "set shutdown in two hours":
                    SetTime(2, 0, 0);
                    StartCountdown();
                    break;
                case "exit application":
                    Application.Exit();
                    break;
            }
            okPenga = false;
            lblListening.Visible = false;
        }

        private void SetTime(int hours,int minutes,int seconds)
        {
            ucHours.Time = hours;
            ucMinutes.Time = minutes;
            ucSeconds.Time = seconds;
        }

    }

}
