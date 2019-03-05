using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektEins
{
    public partial class ViktorControl : UserControl
    {
        public ViktorControl()
        {
            InitializeComponent();

            pictureBox1.DataBindings.Add("Left", hScrollBar1, "Value", true, DataSourceUpdateMode.OnPropertyChanged) ;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.label1.Text = this.dateTimePicker1.Text;
        }
    }
}
