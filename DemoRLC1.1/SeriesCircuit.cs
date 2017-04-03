using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRLC1._1
{
    public class SeriesCircuit : Circuit
    {
        public SeriesCircuit()
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

        public override double SumVoltage()
        {
            this.voltage_sum = voltage1 + voltage2 + voltage3;
            return voltage_sum;
        }

        public override double SumCurrent()
        {
            current1 = current2 = current3 = current_sum;
            return current_sum;
        }
    }
}
