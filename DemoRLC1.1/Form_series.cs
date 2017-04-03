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
    public partial class Form_series : Form
    {
        public SeriesCircuit circuit = new SeriesCircuit();

        public void showParameters(int VoltageCurrent)
        {
            this.label_resistor.Text = circuit.res1.GetResistance().ToString()+"Ом";
            this.label_capacitor.Text = circuit.cap1.GetCapacity().ToString() + "Ф";
            this.label_inductor.Text = circuit.ind1.GetInductance().ToString() + "Гн";
            if(VoltageCurrent==1)
            {
                this.label_voltage.Text = "";
                this.label_current.Text = "I = " + circuit.getCurrent().ToString() + "A";
            }
            if(VoltageCurrent==0)
            {
                this.label_current.Text = "";
                this.label_voltage.Text = "U = " + circuit.getVoltageSum().ToString() + "В";
            }
        }

        public Form_series()
        {
            InitializeComponent();
            //showParameters();
        }

        private void изменитьПараметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parameters param1 = new Parameters(0);
            param1.Owner = this;
            param1.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закончить работу?", "Завершение работы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }

        private void последовательноеСоединениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите закрыть текущую схему?",
                "Новая схема",MessageBoxButtons.YesNo,MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                Parameters fParam = new Parameters(0);
                Form_series fseries = new Form_series();
                fParam.Owner = fseries;
                fParam.Show();
                this.Close(); }
        }

        private void Form_series_Load(object sender, EventArgs e)
        {

        }

        private void параллельноеСоединениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите закрыть текущую схему?",
                "Новая схема", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Parameters fParam = new Parameters(1);
                Form_parallel fParallel = new Form_parallel();
                fParam.Owner = fParallel;
                fParam.Show();
                this.Close();
            }
        }
    }
}
