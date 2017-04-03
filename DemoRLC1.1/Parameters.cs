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
    public partial class Parameters : Form
    {
        bool exitCode = false;
        int VoltCurr = -1;
        int CircuitType = -1;

        //public static SeriesCircuit circuit = new SeriesCircuit();

        public Parameters(int type)
        {
            CircuitType = type;
            InitializeComponent();
        }

        private void SetParameters(Form_parallel mainForm)
        {
            //Form_series mainForm = (Form_series)this.Owner;
            bool setRes = false;
            bool setInd = false;
            bool setCap = false;
            bool setSum = false;

            double result;

            // Resistor
            if (Double.TryParse(this.textBox_resistance.Text, out result))
            {
                mainForm.circuit.res1.SetResistance(Double.Parse(textBox_resistance.Text));
                //circuit.res1.SetResistance(Double.Parse(textBox_resistance.Text));
                setRes = true;
            }
            else
            {
                MessageBox.Show("Incorrect data! Please enter a number!");
            }

            //Inductor
            if (Double.TryParse(this.textBox_inductance.Text, out result))
            {
                mainForm.circuit.ind1.SetInductance(Double.Parse(textBox_inductance.Text));
                setInd = true;
            }
            else
            {
                MessageBox.Show("Incorrect data! Please enter inductance again!");
            }

            //Capacitor
            if (Double.TryParse(this.textBox_capacity.Text, out result))
            {
                mainForm.circuit.cap1.SetCapacity(Double.Parse(textBox_capacity.Text));
                setCap = true;
            }
            else
            {
                MessageBox.Show("Incorrect data, try to enter capacity again!");
            }

            //Voltage or Current
            if (Double.TryParse(this.textBox_voltSum.Text, out result))
            {
                if (this.listBox_volt_cur.SelectedIndex == 0)
                {
                    mainForm.circuit.setVoltageSum(Double.Parse(textBox_voltSum.Text));
                    setSum = true;
                    VoltCurr = 0;
                }
                if (this.listBox_volt_cur.SelectedIndex == 1)
                {
                    mainForm.circuit.setCurrentSum(Double.Parse(textBox_voltSum.Text));
                    setSum = true;
                    VoltCurr = 1;
                }
            }
            else
            {
                MessageBox.Show("Incorrect data, try to enter voltage again!");
            }


            exitCode = setCap & setRes & setInd & setSum;
        }

        private void SetParameters(Form_series mainForm)
        {
            //Form_series mainForm = (Form_series)this.Owner;
            bool setRes = false;
            bool setInd = false;
            bool setCap = false;
            bool setSum = false;

            double result;

            // Resistor
            if (Double.TryParse(this.textBox_resistance.Text, out result))
            {
                mainForm.circuit.res1.SetResistance(Double.Parse(textBox_resistance.Text));
                //circuit.res1.SetResistance(Double.Parse(textBox_resistance.Text));
                setRes = true;               
            }
            else
            {
                MessageBox.Show("Incorrect data! Please enter a number!");
            }

            //Inductor
            if (Double.TryParse(this.textBox_inductance.Text, out result))
            {
                mainForm.circuit.ind1.SetInductance(Double.Parse(textBox_inductance.Text));
                setInd = true;
            }
            else
            {
                MessageBox.Show("Incorrect data! Please enter inductance again!");
            }

            //Capacitor
            if (Double.TryParse(this.textBox_capacity.Text, out result))
            {
                mainForm.circuit.cap1.SetCapacity(Double.Parse(textBox_capacity.Text));
                setCap = true;
            }
            else
            {
                MessageBox.Show("Incorrect data, try to enter capacity again!");
            }

            //Voltage or Current
            if(Double.TryParse(this.textBox_voltSum.Text, out result))
            {
                if (this.listBox_volt_cur.SelectedIndex == 0)
                {
                    mainForm.circuit.setVoltageSum(Double.Parse(textBox_voltSum.Text));
                    setSum = true;
                    VoltCurr = 0;
                }
                    if (this.listBox_volt_cur.SelectedIndex == 1)
                    {
                        mainForm.circuit.setCurrentSum(Double.Parse(textBox_voltSum.Text));
                        setSum = true;
                        VoltCurr = 1;
                    }
            }
            else
            {
                MessageBox.Show("Incorrect data, try to enter voltage again!");
            }


            exitCode = setCap & setRes & setInd & setSum;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (CircuitType == 0)
            {
                Form_series mainForm = (Form_series)this.Owner;

                this.SetParameters(mainForm);
                if (exitCode)
                {
                    mainForm.Show();
                    this.Close();
                    mainForm.showParameters(VoltCurr);
                }
                else
                {
                    MessageBox.Show("Something went wrong :(");
                }
            }
            if(CircuitType==1)
            {
                Form_parallel mainForm = (Form_parallel)this.Owner;

                this.SetParameters(mainForm);
                if (exitCode)
                {
                    mainForm.Show();
                    this.Close();
                    mainForm.showParameters(VoltCurr);
                }
                else
                {
                    MessageBox.Show("Something went wrong :(");
                }
            }
        }
    }
}
