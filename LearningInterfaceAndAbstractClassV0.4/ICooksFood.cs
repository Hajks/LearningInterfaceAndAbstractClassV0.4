﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._4
{
    interface ICooksFood
    {
        int Capacity { get; }
        void HeatUp();
        void Reheat();
    }
}
