using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRLC1._1
{
    public class Resistor
    {
        private double Resistance;
        private double Voltage;
        private double Current;

        public Resistor()
        {
            this.Resistance = 0;
            this.Current = 0;
            this.Voltage = 0;
        }

        //Get and Set
        public double GetResistance()
        {
            return this.Resistance;
        }
        public double GetCurrent()
        {
            return this.Current;
        }
        public double GetVoltage()
        {
            return this.Voltage;
        }

        public void SetResistance(double res)
        {
            this.Resistance = res;
        }
        public void SetCurrent(double cur)
        {
            this.Current = cur;
        }
        public void SetVoltage(double vol)
        {
            this.Voltage = vol;
        }
    }
}
