using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRLC1._1
{
    public class Capacitor
    {
        private double Capacity;
        private double Voltage;
        private double Current;
        private double Resistance;

        public Capacitor()
        {
            this.Capacity = 0;
            this.Capacity = 0;
            this.Voltage = 0;
            this.Resistance = 0;
        }

        //Get and Set
        public double GetCapacity()
        {
            return this.Capacity;
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

        public void SetCapacity(double cap)
        {
            this.Capacity = cap;
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
