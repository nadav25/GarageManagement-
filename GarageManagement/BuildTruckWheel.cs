using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagement
{
    public class BuildTruckWheel : BuildWheel
    {
        public BuildTruckWheel()
        {
            m_NumOfWheel = 12;
            m_MaximumAmount = 34;
        }
    }
}

