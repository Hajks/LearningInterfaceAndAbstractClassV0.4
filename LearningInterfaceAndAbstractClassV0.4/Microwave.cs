using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._4
{
    class Microwave : Appliance, ICooksFood // we can ustr ctrl + "." to autoimplement all necessary fields and methods.
    {
        public int Capacity => throw new NotImplementedException();

        public void HeatUp()
        {
            throw new NotImplementedException();
        }

        public void Reheat()
        {
            throw new NotImplementedException();
        }
    }
}
