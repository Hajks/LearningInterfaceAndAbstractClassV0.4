using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._4
{
    public class Oven : Appliance, ICooksFood
    {
        public int Capacity { get; }
        public void Preheat() { }
        public void HeatUp() { }
        public void Reheat() { }

    }
}
