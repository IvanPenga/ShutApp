using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShutApp
{
    public partial class ucTime : UserControl
    {
        public ucTime greater;

        private int time = 0;
        public int Time
        {
            get { return time; }
            set
            {
                time = value;
                CheckTime();
            }
        }

        public Size BtnSize
        {
            get { return btnDown.Size; }
            set { btnDown.Size = value; btnUp.Size = value; }
        }
            

        public string TimeStampHMS
        {
            get { return lblTimeHMS.Text; }
            set { lblTimeHMS.Text = value; }
        }


        public ucTime()
        {
            InitializeComponent();
            this.MouseWheel += PictureBox1_MouseWheel;       

        }

        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            if (e.Delta > 0) btnUp_Click(this,EventArgs.Empty);
            if (e.Delta < 0) btnDown_Click(this, EventArgs.Empty);
        }

        public bool IsHour { get; set; }

        private void CheckTime()
        {
            if (time <= -1 && IsHour == false)
            {
                time = 59;
                greater.Time--;
            }
            if (time >= 60 && IsHour == false)
            {
                if (greater.IsHour && greater.time >= 999)
                {
                    return;
                }
                time = 0;
                greater.Time++;
            }
            label1.Text = time.ToString();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (this.Time != 0 || greater.Time != 0 || greater.greater.Time != 0)
            {
                time--;
                CheckTime();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (IsHour && time >= 999)
            {
                return;
            }
            time++;
            CheckTime();
        }

        public void DisableButtons()
        {
            this.btnDown.Enabled = false;
            this.btnUp.Enabled = false;
        }
        public void EnableButtons()
        {
            this.btnDown.Enabled = true;
            this.btnUp.Enabled = true;
        }
    }
}
