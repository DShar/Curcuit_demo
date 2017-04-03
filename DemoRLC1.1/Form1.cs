using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoRLC1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_series_Click(object sender, EventArgs e)
        {
            Parameters fParam = new Parameters(0);
            Form_series fseries = new Form_series();
            fParam.Owner = fseries;
            fParam.Show();
            this.Hide();
        }

        private void button_parallel_Click(object sender, EventArgs e)
        {
            Parameters fParam = new Parameters(1);
            Form_parallel fparallel = new Form_parallel();
            fParam.Owner = fparallel;
            fParam.Show();
            this.Hide();
        }
    }
}
