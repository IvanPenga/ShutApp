using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutApp
{
    public partial class ccRadioLabel : Label
    {
        private bool check = false;
        public bool Checked
        {
            get { return check; }
            set
            {
                check = value;
                if (check == true)
                {
                    this.ForeColor = Color.CornflowerBlue;
                }
                else
                {
                    this.ForeColor = Color.White;
                }
            }
        }

        public bool Enable { get; set; } = true;

        public ccRadioLabel()
        {
            InitializeComponent();
            this.Click += CcRadioLabel_Click;
            this.Font = new Font("Microsoft NeoGothic", 18);

        }

        private void CcRadioLabel_Click(object sender, EventArgs e)
        {           
            if (!Enable)
            {
                return;
            }
            foreach (var item in this.FindForm().Controls.OfType<ccRadioLabel>())
            {
                item.Checked = false;
            }
            Checked = true;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
