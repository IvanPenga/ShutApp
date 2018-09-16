using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutApp
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            cmbDefaultOperation.DataSource = Enum.GetValues(typeof(Operation));

            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            Enum.TryParse<Operation>(cmbDefaultOperation.SelectedValue.ToString(), out Operation operation);

            Config.Save("defaultOperation",operation.ToString());
        }

        public new void Hide()
        {
            this.SendToBack();
            this.Visible = false;
        }

        public new void Show()
        {
            this.Visible = true;
            this.BringToFront();
        }

        private void cmbDefaultOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
