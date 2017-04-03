using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRLC1._1
{
    public class Circuit
    {
        public Resistor res1 = new Resistor();
        public Inductor ind1 = new Inductor();
        public Capacitor cap1 = new Capacitor();

        protected double voltage_sum;
        protected double current_sum;
        protected double resistance_sum;
        protected double resistance1, resistance2, resistance3;
        protected double current1, current2, current3;
        protected double voltage1, voltage2, voltage3;

        public Circuit()
        {
            this.voltage1 = res1.GetVoltage();
            this.voltage2 = ind1.GetVoltage();
            this.voltage3 = cap1.GetVoltage();

            this.current1 = res1.GetCurrent();
            this.current2 = ind1.GetCurrent();
            this.current3 = cap1.GetCurrent();

            this.resistance1 = res1.GetResistance();
            this.resistance2 = ind1.GetResistance();
            this.resistance3 = cap1.GetResistance();
        }

        //Set & Get

        //Voltage
        public void setVoltageSum(double vol)
        {
            this.voltage_sum = vol;
        }

        public double getVoltageSum()
        {
            return this.voltage_sum;
        }

        //Current
        public void setCurrentSum(double cur)
        {
            this.current_sum = cur;
        }
        public double getCurrent()
        {
            return this.current_sum;
        }

        //virtual methods
        public virtual double SumVoltage()
        {
            return voltage_sum;
        }
        public virtual double SumCurrent()
        {
            return current_sum;
        }
        public virtual double SumResistance()
        {
            return resistance_sum;
        }

    }
}
