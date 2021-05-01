using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusFeatures
{
    public partial class MalwareFeatures : Form
    {
        public MalwareFeatures()
        {
            InitializeComponent();
        }

        private void MalwareFeatures_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(uncloseableForm.Value)
            {
                e.Cancel = true;
            }
        }

        private void MalwareFeatures_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void hideInTaskBar_OnValueChange(object sender, EventArgs e)
        {
            this.ShowInTaskbar = !hideInTaskBar.Value;
        }
    }
}
