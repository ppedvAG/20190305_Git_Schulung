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
    public partial class AndreControl : UserControl
    {
        public AndreControl()
        {
            InitializeComponent();
            progressBar1.DataBindings.Add(nameof(ProgressBar.Value), trackBar1, nameof(TrackBar.Value), true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
