using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRLC1._1
{
    public class Inductor
    {
        private double Inductance;
        private double Voltage;
        private double Current;
        private double Resistance;

        public Inductor()
        {
            this.Inductance = 0;
            this.Current = 0;
            this.Voltage = 0;
            this.Resistance = 0;
        }

        //Get and Set
        public double GetInductance()
        {
            return this.Inductance;
        }
        public double GetCurrent()
        {
            return this.Current;
        }
        public double GetVoltage()
        {
            return this.Voltage;
        }
        public double GetResistance()
        {
            return this.Resistance;
        }

        public void SetInductance(double ind)
        {
            this.Inductance = ind;
        }
        public void SetCurrent(double cur)
        {
            this.Current = cur;
        }
        public void SetVoltage(double vol)
        {
            this.Voltage = vol;
        }
        public void SetResistance(double res)
        {
            this.Resistance = res;
        }
    }
}
